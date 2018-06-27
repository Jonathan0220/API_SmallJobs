using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TM_WebApi_SmallJobs.Models
{
    public class TMUsuarios
    {
        public string nombre { get; set; }
        public string correo { get; set; }
        public string constraseña { get; set; }
        public string ubicacion { get; set; }
        public string tipoUsuario { get; set; }
    }
}