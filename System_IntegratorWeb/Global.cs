using System.Data;

namespace System_IntegratorWeb
{
    public class Global

    {
        //---------Servers---------
        //public const string Server = "think";
        //public const string Server = "itserver";

        //public const string Server = "101.50.81";
        public const string Server = "THINK";
        //public const string webSiteServer = "217.174.153.85";

        //---------Databases---------
        public const string DBName = "MH_SysIntGH";

        //public const string webSiteDBName = "braveuser_staging";

        //---------Connection---------

        //Public Const Conn = "Initial catalog=" & DBName & ";data source=" & Server & "; Integrated Security=True"

        //Other
        public const string Conn = "Initial catalog=" + DBName + ";data source=" + Server + "; User Id=sa; Password=it@mh123";

        public static string? EmpCode { get; set; }
        public static string? EmpName { get; set; }
        public static string? EmpDesignation { get; set; }
        public static string? userID { get; set; }
        public static string? ImagePath { get; set; }
        public static string? userName { get; set; }
        public static string? computerName { get; set; }

        public static void Clear()
        {
            userID = string.Empty;
            EmpCode = string.Empty;
        }
        public static bool FindInT(DataTable dt, string ColName1, string ColValue1, string ColName2, string ColValue2)
        {
            ColValue1 = ColValue1.Trim();
            ColValue2 = ColValue2.Trim();
            foreach (DataRow row in dt.Rows)
            {
                if (string.Equals(row[ColName1].ToString().Trim(), ColValue1, StringComparison.InvariantCultureIgnoreCase) && string.Equals(row[ColName2].ToString().Trim(), ColValue2, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}