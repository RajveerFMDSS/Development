using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDSS.Infrastructure.CommanModel
{
  

        public static class Config
        {
            public static string AuthContext
            {
                get
                {
                    string connectionString = "";
                    if (!string.IsNullOrEmpty(AppSettings.AuthContext))
                        connectionString = AppSettings.AuthContext;
                    else if (!string.IsNullOrEmpty(ConnectionStrings.AuthContext))
                        connectionString = ConnectionStrings.AuthContext;
                    else
                        connectionString = "Data Source=data source=10.68.107.11;initial catalog=db_FMDSS;persist security info=True;user id=sa;password=forest;MultipleActiveResultSets=True;App=EntityFramework; providerName = System.Data.SqlClient";
                    return connectionString;
                }
            }

            private static class AppSettings
            {
                public static string AuthContext
                {
                    get
                    {
                        string connectionString = "";
                        if (ConfigurationManager.AppSettings.AllKeys.Contains("AUTH_CONTEXT"))
                        {
                            connectionString = ConfigurationManager.AppSettings["AUTH_CONTEXT"];
                        }
                        return connectionString;
                    }
                }
            }

            private static class ConnectionStrings
            {
                public static string AuthContext
                {
                    get
                    {
                        string connectionString = "";
                        if (ConfigurationManager.ConnectionStrings["db_FMDSS"] != null)
                        {
                            connectionString = ConfigurationManager.ConnectionStrings["db_FMDSS"].ConnectionString;
                        }
                        return connectionString;
                    }
                }
            }
        }
    }
