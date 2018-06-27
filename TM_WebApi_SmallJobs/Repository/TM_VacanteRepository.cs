using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TM_WebApi_SmallJobs.Interfaces;
using TM_WebApi_SmallJobs.Models;
using System.Data.SqlClient;
using System.Data;

namespace TM_WebApi_SmallJobs.Repository
{
    public class TM_VacanteRepository : ITMVacante
    {
        public int registrarVacante(Models.TMVacante mdVacante)
        {
            
            int resultado = 0;
            int? vacanteID = null;

            using (SmallJobsSqlDataContext dataContext = SmallJobsSqlDataContext.GetDataContext())
            {
                dataContext.sp_AltaVacante(mdVacante.idUsuario, mdVacante.nombreVacante, mdVacante.descripcion, mdVacante.tipoPedido, mdVacante.numeroContacto, mdVacante.direccion, mdVacante.fechaInicio, mdVacante.fechaFin);

                resultado = Convert.ToInt32(vacanteID);
            }
            
            return resultado;
        }



        public Models.TMVacante obtenerVacante(string nombreVacante)
        {
            Models.TMVacante mVacante = new Models.TMVacante();
            using (SmallJobsSqlDataContext dataContext = SmallJobsSqlDataContext.GetDataContext())
            {

                var result = dataContext.sp_ConsultaVacante(nombreVacante).Select(h => new Models.TMVacante()
                {
                    descripcion = h.Descripcion,
                    direccion = h.Direccion,
                    nombreVacante = h.NombreVacante,
                    fechaInicio = h.FechaInicio,
                    fechaFin = h.FechaFin,
                    idUsuario = Convert.ToInt32(h.idUsuario),
                    numeroContacto = h.NumContacto,
                    tipoPedido = h.TipoPedido,

                }).ToArray();

                if (result.Any())
                {
                    mVacante = new Models.TMVacante();
                    mVacante.nombreVacante = result[0].nombreVacante;
                    mVacante.descripcion = result[0].descripcion;
                    mVacante.direccion = result[0].direccion;
                    mVacante.numeroContacto = result[0].numeroContacto;
                    mVacante.tipoPedido = result[0].tipoPedido;
                    mVacante.fechaInicio = result[0].fechaInicio;
                    mVacante.fechaFin = result[0].fechaFin;
                    mVacante.idUsuario = result[0].idUsuario;
                }

            }
            return mVacante;
        }

        public bool actualizarVacante(string Correo, Models.TMVacante mVacante)
        {
            bool respuesta = false;
            SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString("TM_SMALLJOBSConnectionStringADO"));
            SqlCommand cmdUpdVacante = new SqlCommand("sp_ActualizaVacante", conn);
            cmdUpdVacante.CommandType = CommandType.StoredProcedure;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@NombreVacante", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@NombreVacante"].Value = mVacante.nombreVacante;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@Descripcion"].Value = mVacante.descripcion;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@TipoPedido", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@TipoPedido"].Value = mVacante.tipoPedido;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@NumContacto", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@NumContacto"].Value = mVacante.numeroContacto;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@Direccion"].Value = mVacante.direccion;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@FechaInicio", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@FechaInicio"].Value = mVacante.fechaInicio;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@FechaFin", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@FechaFin"].Value = mVacante.fechaFin;

            cmdUpdVacante.Parameters.Add(new SqlParameter("@Correo", SqlDbType.VarChar));
            cmdUpdVacante.Parameters["@Correo"].Value = Correo;

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


        public bool eliminaVacante(string vacante)
        {
            bool respuesta = false;
            SqlConnection conn = new SqlConnection(ConnectionString.GetConnectionString("TM_SMALLJOBSConnectionStringADO"));
            SqlCommand cmdDelVacante = new SqlCommand("sp_BajaVacante", conn);
            cmdDelVacante.CommandType = CommandType.StoredProcedure;

            cmdDelVacante.Parameters.Add(new SqlParameter("@NombreVacante", SqlDbType.VarChar));
            cmdDelVacante.Parameters["@NombreVacante"].Value = vacante;

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