using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnection
{
    public static class ConnectStringHelper
    {
        public static string GetCurrentString()
        {
            return ConfigurationManager.AppSettings["conStr"];
        }
    }
}
