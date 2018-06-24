using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace TM_WebApi_SmallJobs.Repository
{
    public class ConnectionString
    {
        public static string GetConnectionString(string name)
        {

            var connstr = ConfigurationManager.ConnectionStrings[name];

            if (connstr != null)
                return connstr.ConnectionString;

            throw new Exception("No se encontro la conexion");

        }
    }
}