using System;
using System.Configuration;

namespace ATM_DataAccess
{
    public class clsSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["ATMConnection"].ConnectionString;
    }
}
