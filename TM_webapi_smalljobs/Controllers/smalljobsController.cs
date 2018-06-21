using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TM_webapi_smalljobs.Interface;
using TM_webapi_smalljobs.Repository;

namespace TM_webapi_smalljobs.Controllers
{
    public class smalljobsController : ApiController
    {
        //implememtacion de la interface 

        private readonly ITMVacante ivacante= new TM_VacanteRepository();

        [HttpGet]
        public HttpResponseMessage registrarVacante(Models.TMVacante mdVacante) {
            HttpResponseMessage msg = new HttpResponseMessage();
            try {
                var vacante = ivacante.registrarVacante(mdVacante);
                msg = Request.CreateResponse<Models.TMVacante>(HttpStatusCode.Created, vacante);
            } catch (Exception ex) {
                msg = Request.CreateResponse<string>(HttpStatusCode.InternalServerError, ex.ToString());
            }


            return msg;

        }

    }
}
