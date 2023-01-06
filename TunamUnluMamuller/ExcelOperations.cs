using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Drawing;

namespace TunamUnluMamuller
{
    internal static class ExcelOperations
    {
        public static void ExportWithExcel(DataGridView dataGrid)
        {
            int column = 1;
            int row = 1;
            Excel.Application excel_App = new Excel.Application();
            excel_App.Workbooks.Add();
            excel_App.Visible = true;
            excel_App.Worksheets[1].Activate();

            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
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
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for (int k = 0; k < dataGrid.Columns.Count; k++)
                {
                    excel_App.Cells[row + i, column + k].Value = dataGrid[k, i].Value;
                }
            }
        }
    }
}
