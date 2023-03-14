using System;
using System.Threading;

namespace TunamUnluMamuller.Scripts {
    public static class Utility {
        public static void Sleep(int delay) => Thread.Sleep(delay);

        public static Branches branch;
        public enum Branches { DilimBorek, Musluoglu }

        public static PullBranches pullBranches;
        public enum PullBranches { Both, Ankara, Istanbul }
    }
}
