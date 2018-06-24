using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TM_WebApi_SmallJobs.Models
{
    public class TMVacante
    {
        public int idUsuario { get; set; }
        public string nombreVacante { get; set; }
        public string descripcion { get; set; }
        public string tipoPedido { get; set; }
        public string numeroContacto { get; set; }
        public string direccion { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
    }
}