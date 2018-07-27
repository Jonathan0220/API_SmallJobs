using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TM_WebApi_SmallJobs.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace TM_WebApi_SmallJobs.Repository
{
    public class TM_UsuariosRepository : IUsuarios
    {
        public Models.TMUsuarios obtenerUsuario(string correo) {
            Models.TMUsuarios musuario = new Models.TMUsuarios();
            using (SmallJobsSqlDataContext dataContext = SmallJobsSqlDataContext.GetDataContext())
            {

                var result = dataContext.sp_ConsultaUsuarios(correo).Select(h => new Models.TMUsuarios()
                {
                    nombre = h.Nombre,
                    correo = h.Correo,
                    contraseña = h.Contraseña,
                    ubicacion = h.Ubicacion,
                    tipoUsuario = h.tipoUsuario,
                    
                }).ToArray();

                if (result.Any())
                {
                    musuario = new Models.TMUsuarios();
                    musuario.nombre = result[0].nombre;
                    musuario.correo = result[0].correo;
                    musuario.contraseña = result[0].contraseña;
                    musuario.ubicacion = result[0].ubicacion;
                    musuario.tipoUsuario = result[0].tipoUsuario;
                }
            }
            return musuario;
        }

        public int registrarusuario(Models.TMUsuarios musuario) {
            int resultado = 0;
            try
            {
                using (SmallJobsSqlDataContext datacontext = SmallJobsSqlDataContext.GetDataContext())
                {
                    datacontext.sp_AltaUsuarios(musuario.nombre, musuario.correo, musuario.contraseña, musuario.ubicacion, musuario.tipoUsuario);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultado;
        }

        public bool actualizarusuario(string correo, Models.TMUsuarios musuario) {
            bool respuesta = false;
            SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString("TM_SMALLJOBSConnectionStringADO"));
            SqlCommand cmdUpdVacante = new SqlCommand("sp_ActualizaUsuario", conn);
            cmdUpdVacante.CommandType = CommandType.StoredProcedure;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@Nombre"].Value = musuario.nombre;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@Correo"].Value = musuario.correo;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@Contraseña"].Value = musuario.contraseña;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@Ubicacion", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@Ubicacion"].Value = musuario.ubicacion;
            try
            {
                conn.Open();
                cmdUpdVacante.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception EX)
            {
                throw EX;
            }
            finally
            {
                conn.Close();
            }
            return respuesta;
        }


        public bool eliminausuario(int idUsuario) {
            bool respuesta = false;
            SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString("TM_SMALLJOBSConnectionStringADO"));
            SqlCommand cmdDelVacante = new SqlCommand("sp_BajaUsuarios", conn);
            cmdDelVacante.CommandType = CommandType.StoredProcedure;

            cmdDelVacante.Parameters.Add(new SqlParameter("@idUsuario", SqlDbType.VarChar));
            cmdDelVacante.Parameters["@idUsuario"].Value = idUsuario;

            try
            {
                conn.Open();
                cmdDelVacante.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return respuesta;
        }
    }
}