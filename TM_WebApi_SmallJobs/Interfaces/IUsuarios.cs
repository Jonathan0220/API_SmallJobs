using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_WebApi_SmallJobs.Interfaces
{
    interface IUsuarios
    {
        Models.TMUsuarios obtenerUsuario(string correo);
        int registrarusuario(Models.TMUsuarios musuario);
        bool actualizarusuario(string correo, Models.TMUsuarios musuario);
        bool eliminausuario(int idUsuario);

    }
}
