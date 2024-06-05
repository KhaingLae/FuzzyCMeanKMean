using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace FuzzyCMeansKMeans
{
    class Config
    {
        public static string AppTitle = "Fuzzy C-Means and K-Means Clustering";
        public static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Dentition.mdb";

        public static double accuracy = 0.00001;
        public static DataTable originalTable;
        public static DataTable[] tableArray;

        public static int kCluster, cCluster;
        public static List<int> kMember, cMember;
        public static int kTime, cTime;
    }
}
