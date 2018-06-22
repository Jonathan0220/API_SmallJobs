﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_webapi_smalljobs.Interface
{
    interface ITMVacante
    {
        int registrarVacante(Models.TMVacante mdVacante);
        Models.TMVacante obtenerVacante(string nombreVacante);
        bool actualizarVacante(string Correo, Models.TMVacante mVacante);
        bool eliminaVacante(string vacante);
    }
}