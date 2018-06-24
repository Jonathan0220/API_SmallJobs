using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TM_WebApi_SmallJobs.Interfaces;
using TM_WebApi_SmallJobs.Repository;

namespace TM_WebApi_SmallJobs.Controllers
{
    public class smalljobsController : ApiController
    {
        //implememtacion de la interface 
        private readonly ITMVacante ivacante = new TM_VacanteRepository();

        /* Modulo de vacante */
        [HttpGet]
        public HttpResponseMessage obtenerVacante(string nombreVacante)
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            try
            {
                var vacante = ivacante.obtenerVacante(nombreVacante);
                msg = Request.CreateResponse<Models.TMVacante>(HttpStatusCode.Created, vacante);
            }
            catch (Exception ex)
            {
                msg = Request.CreateResponse<string>(HttpStatusCode.InternalServerError, ex.ToString());
            }
            return msg;

        }

        [HttpPost]
        public HttpResponseMessage registrarVacante(Models.TMVacante mdVacante)
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            try
            {
                var vacante = ivacante.registrarVacante(mdVacante);
                msg = Request.CreateResponse<int>(HttpStatusCode.Created, vacante);
            }
            catch (Exception ee)
            {
                msg = Request.CreateResponse<string>(HttpStatusCode.InternalServerError, ee.ToString());
            }
            return msg;
        }

        [HttpPut]
        public HttpResponseMessage actualizarVacante(string Correo, Models.TMVacante mdVacante)
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            try
            {
                var vacante = ivacante.actualizarVacante(Correo, mdVacante);
                msg = Request.CreateResponse<bool>(HttpStatusCode.Accepted, vacante);
            }
            catch (Exception ee)
            {
                msg = Request.CreateResponse<string>(HttpStatusCode.InternalServerError, ee.ToString());
            }
            return msg;
        }

        [HttpDelete]
        public HttpResponseMessage eliminarVacante(string nombreVacante)
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            try
            {
                var vacante = ivacante.eliminaVacante(nombreVacante);
                msg = Request.CreateResponse<bool>(HttpStatusCode.Created, vacante);
            }
            catch (Exception ee)
            {
                msg = Request.CreateResponse<string>(HttpStatusCode.InternalServerError, ee.ToString());
            }
            return msg;
        }


    }
}
