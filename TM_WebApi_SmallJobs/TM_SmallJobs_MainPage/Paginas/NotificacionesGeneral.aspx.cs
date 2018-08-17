using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas.clases;
using System.Data;

namespace TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas
{
    public partial class NotificacionesGeneral : System.Web.UI.Page
    {


        /*General manda a voluntario 
            
            voluntario = 3
             
             */
        private int idUsuario = Loggin.ID;
        private string tipoUsuario;
        private string Usuario = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //obtenerDatosUsuario();
            //llenartabla();

        }
        private void llenartabla()
        {

           //string strConnString = ConfigurationManager.ConnectionStrings["TM_SMALLJOBSConnectionString"].ConnectionString;
            //SqlConnection myConnection = new SqlConnection(strConnString);

            //string strSQLSelect = "SELECT * FROM ADMS_Machining ";
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = "Data Source=localhost;Initial Catalog=TM_SMALLJOBS;Integrated Security=True;";
            string strSQLSelect = "SELECT [idVacante],[NombreVacante],[Descripcion],[TipoPedido],[FechaInicio],[FechaFin] FROM [TM_SMALLJOBS].[dbo].[Vacante]";
            SqlCommand selectCommand = new SqlCommand(strSQLSelect, myConnection);
            selectCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter Adapter = new SqlDataAdapter(selectCommand);
            try
            {
                myConnection.Open();
                DataSet ds = new DataSet();
                Adapter.Fill(ds, "Producto");
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch (Exception err)
            {

                Console.Write(err);
            }
            finally
            {
                myConnection.Close();
            }

        }

        private void obtenerDatosUsuario() {
            SqlDataReader rd = getUsuario.getUsuarioid(idUsuario);
            if (rd != null)
            {
                Usuario = Convert.ToString(rd["Nombre"]);
                
            }
        }

       
        protected void sendNotification(object sender, CommandEventArgs e)
        {
            /*  Se manda notificacion a usuario voluntario  */
            string mensaje = "";
            if (e.CommandName.Equals("Rechaza"))
            {
                mensaje = "El usuario " + Usuario + " ha rechazado tu oferta, sigue buscando";

            }
            else if (e.CommandName.Equals("Acepta")) {
                mensaje = "El usuario " + Usuario + " ha aceptado tu oferta, mucha suerte";
            }
            var constr = ConfigurationManager.ConnectionStrings["TM_SMALLJOBSConnectionString"].ConnectionString;
            SqlConnection cnn = new SqlConnection(constr);
            cnn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Notificacion (idUsuarioActual, idUsuarioDestino, Descripcion) values (" + idUsuario + ", 3, '" + mensaje + "');", cnn);
            cmd.ExecuteNonQuery();


        }
    }
}