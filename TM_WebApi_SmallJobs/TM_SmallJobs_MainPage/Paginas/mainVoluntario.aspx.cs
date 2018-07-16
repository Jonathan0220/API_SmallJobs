using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TM_WebApi_SmallJobs.TM_SmallJobs_MainPage.Paginas
{
    public partial class mainVoluntario : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            idUsuario.Text = Convert.ToString(Loggin.ID);
           
            if (!IsPostBack) {
                BindRepeater();
            }
           
        }

        public void BindRepeater() {
            var constr = ConfigurationManager.ConnectionStrings["TM_SMALLJOBSConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(constr)) {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Vacante", conn)) {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd)) {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        RepeaterVacante.DataSource = dt;
                        RepeaterVacante.DataBind();
                    }
                }

            }

        }
        override protected void OnInit(EventArgs e)
        {
            base.OnInit(e);
            RepeaterVacante.ItemCommand += new RepeaterCommandEventHandler(rptData_ItemCommand);
        }

        private void rptData_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
           
        }

    }
}