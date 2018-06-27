using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TM_WebApi_SmallJobs.Interfaces;

namespace TM_WebApi_SmallJobs.Repository
{
    public class TM_UsuariosRepository : IUsuarios
    {
        public Models.TMUsuarios obtenerUsuario(string correo) {
            Models.TMUsuarios musuario = new Models.TMUsuarios();
            try
            {
             
            }
            catch (Exception)
            {

                throw;
            }
            return musuario;
        }

        public int registrarusuario(Models.TMUsuarios musuario) {
            int resultado = 0;

            try
            {
                using (SmallJobsSqlDataContext datacontext = SmallJobsSqlDataContext.GetDataContext())
                {
                    datacontext.sp_AltaUsuarios(musuario.nombre, musuario.correo, musuario.constraseña, musuario.ubicacion, musuario.tipoUsuario);

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



            return respuesta;
        }


        public bool eliminausuario(int idUsuario) { }





    }
}