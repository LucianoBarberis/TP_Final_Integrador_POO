using System;
using System.Collections.Generic;
using System.Text;
using Tp_Integrador_Final.Enums;

namespace Tp_Integrador_Final.Modelos
{
    public class Administrador : Usuario
    {
        public Administrador()
        { 
            Rol = Enums.RolesEnum.Admin;
        }
    }
}
