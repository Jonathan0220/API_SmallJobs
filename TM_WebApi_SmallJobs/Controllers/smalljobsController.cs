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
        //implememtacion de interface de vacante 
        private readonly ITMVacante ivacante = new TM_VacanteRepository();

        //Implementacion de interface de usuarios
        private readonly IUsuarios iusuarios = new TM_UsuariosRepository();


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

        /* Modulo de usuarios */
        [HttpGet]
        public HttpResponseMessage obtenerUsuario(string correo) {
            HttpResponseMessage msg = new HttpResponseMessage();
            try
            {
                var usuario = iusuarios.obtenerUsuario(correo);
                msg = Request.CreateResponse<Models.TMUsuarios>(HttpStatusCode.Created, usuario);
            }
            catch (Exception ex)
            {
                msg = Request.CreateResponse<string>(HttpStatusCode.InternalServerError, ex.ToString());
            }
            return msg;
        }

        [HttpPost]
        public HttpResponseMessage registrarUsuario(Models.TMUsuarios musuario, string clave)
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            try
            {
                var usuario = iusuarios.registrarusuario(musuario);
                msg = Request.CreateResponse<int>(HttpStatusCode.Created, usuario);
            }
            catch (Exception ex)
            {
                msg = Request.CreateResponse<string>(HttpStatusCode.InternalServerError, ex.ToString());
            }
            return msg;
        }

        [HttpPut]
        public HttpResponseMessage actualizarUsuario(string correo, string clave, Models.TMUsuarios musuario)
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            try
            {
                var usuario = iusuarios.actualizarusuario(correo, musuario);
                msg = Request.CreateResponse<bool>(HttpStatusCode.Created, usuario);
            }
            catch (Exception ex)
            {
                msg = Request.CreateResponse<string>(HttpStatusCode.InternalServerError, ex.ToString());
            }
            return msg;
        }

        [HttpDelete]
        public HttpResponseMessage eliminarUsuario(int idUsuario)
        {
            HttpResponseMessage msg = new HttpResponseMessage();
            try
            {
                var usuario = iusuarios.eliminausuario(idUsuario);
                msg = Request.CreateResponse<bool>(HttpStatusCode.Created, usuario);
            }
            catch (Exception ex)
            {
                msg = Request.CreateResponse<string>(HttpStatusCode.InternalServerError, ex.ToString());
            }
            return msg;
        }
    }
}
