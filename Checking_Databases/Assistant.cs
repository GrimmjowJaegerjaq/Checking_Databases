using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Checking_Databases
{
    public class Assistant
    {
        public static DataTable checkList = new DataTable();

        public static string EtalonDbName { get; set; } = "";

        public static string EtalonDbConnectionString { get; set; } = "";

        public static List<string> testList = new List<string>();

        public static string Lang { get; set; } = "ru";

        public static string ConnectionString { get; set; } = "";

        public static bool Maximized { get; set; } = false;
    }
}
