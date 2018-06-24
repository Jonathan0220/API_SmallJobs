using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_WebApi_SmallJobs.Interfaces
{
    interface ITMVacante
    {
        int registrarVacante(Models.TMVacante mdVacante);
        Models.TMVacante obtenerVacante(string nombreVacante);
        bool actualizarVacante(string Correo, Models.TMVacante mVacante);
        bool eliminaVacante(string vacante);
    }
}
