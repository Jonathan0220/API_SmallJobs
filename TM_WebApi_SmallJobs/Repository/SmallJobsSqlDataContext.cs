using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TM_WebApi_SmallJobs.Repository
{
    public partial class SmallJobsSqlDataContext
    {
        private const String connectionString = "TM_SMALLJOBSConnectionString";
        public static SmallJobsSqlDataContext GetDataContext()
        {
            string conexion = ConnectionString.GetConnectionString(connectionString);

            if (!string.IsNullOrEmpty(conexion))
                return new SmallJobsSqlDataContext(conexion);

            return null;

        }
    }
}