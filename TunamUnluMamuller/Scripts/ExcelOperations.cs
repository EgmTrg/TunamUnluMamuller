using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Office.Interop.Excel;
using TunamUnluMamuller.Scripts;

namespace TunamUnluMamuller {
    internal class ExcelOperations {
        #region Properties
        private string Branch { get; set; }

        private static Excel.Application excel_App;

        public static Excel.Application Excel_App {
            get { return excel_App; }
            set { excel_App = value; }
        }

        private static Workbook base_Workbook;

        public static Workbook BaseWorkBook {
            get { return base_Workbook; }
            private set { base_Workbook = value; }
        }

        private static Worksheet baseData_Sheet;

        public static Worksheet BaseData {
            get { return baseData_Sheet; }
            private set { baseData_Sheet = value; }
        }
        #endregion

        #region Variables
        private static int DatasRowCount = 100;

        #endregion

        public static void ExportWithExcel(DataGridView dataGrid, Utility.Branches branch) {
            int column = 1;
            int row = 1;
            excel_App = new Excel.Application();
            base_Workbook = excel_App.Workbooks.Add();
            excel_App.Visible = true;
            Worksheet worksheet = excel_App.Worksheets[1];
            worksheet.Activate();

            for (int i = 0; i < dataGrid.Columns.Count; i++) {
                var cell = excel_App.Cells[row, column + i];
                cell.Value = dataGrid.Columns[i].HeaderText;
                cell.Interior.Color = Color.Yellow;
                cell.Font.Color = Color.Black;
                cell.Font.Size = 12;
                cell.ColumnWidth = 20;
                cell.Font.Bold = true;
                cell.Font.Name = "Arial Black";
            }
            row++;
            for (int i = 0; i < dataGrid.Rows.Count; i++) {
                for (int k = 0; k < dataGrid.Columns.Count; k++) {
                    excel_App.Cells[row + i, column + k].Value = dataGrid[k, i].Value;
                }
                DatasRowCount++;
            }
            DoPivot(branch);
        }

        public static void DoPivot(Utility.Branches branch) {
            // Initialize Excel App
            Excel.Application app = Excel_App;

            // Workbook
            Workbook pivot_workBook = app.Workbooks[1];
            Worksheet sheet = pivot_workBook.Sheets["Sayfa1"];
            sheet.Cells.EntireColumn.AutoFit();

            // Initialize Range for Pivot
            string range = branch == Utility.Branches.DilimBorek ? $"A1:F{DatasRowCount}" : $"A1:E{DatasRowCount}";
            Range pivotData_range = sheet.Range[range];

            Worksheet pivotSheet = new Worksheet();
            string pivotTableName = "Siparisler";
            Range pivotDestination = sheet.Range["I5"];
            PivotCache pivotCache = pivot_workBook.PivotCaches().Add(XlPivotTableSourceType.xlDatabase, pivotData_range);
            PivotTable pivotTable = sheet.PivotTables().Add(pivotCache, pivotDestination, pivotTableName);

            // Define the columns
            PivotField header = pivotTable.PivotFields("BAYİ ADI");
            header.Orientation = XlPivotFieldOrientation.xlColumnField;

            // Define the rows
            PivotField rows = pivotTable.PivotFields("SİPARİŞ ADI");
            rows.Orientation = XlPivotFieldOrientation.xlRowField;

            // Define the values
            PivotField field = pivotTable.PivotFields("SİPARİŞ SAYISI");
            field.Orientation = XlPivotFieldOrientation.xlDataField;
            field.Function = XlConsolidationFunction.xlSum;

            // Format the Pivot table
            pivotTable.TableStyle2 = "PivotStyleLight16";
            pivotTable.ShowTableStyleRowStripes = true;
        }
    }
}
