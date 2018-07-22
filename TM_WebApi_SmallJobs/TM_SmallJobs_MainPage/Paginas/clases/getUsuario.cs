using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Management;
using TM_WebApi_SmallJobs.Repository;

namespace TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.clases
{
    public class getUsuario
    {
        public static SqlDataReader getUsuarioid(int idUsuario) {
            var cons = ConnectionString.GetConnectionString("TM_SMALLJOBSConnectionString");
            SqlConnection cnn = new SqlConnection(cons);

            cnn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE idUsuario = " + idUsuario + "", cnn);
            if (cmd != null){
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd != null && rd.Read())
                {
                    return rd;
                }
                else {
                    return null;
                }
            }
            else {
                return null;
            }
            
            
        }
    }
}