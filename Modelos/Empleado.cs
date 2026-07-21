using Tp_Integrador_Final.Enums;

namespace Tp_Integrador_Final.Modelos
{
    public class Empleado : Usuario
    {
        public Empleado()
        {
            Rol = RolesEnum.Empleado;
        }

        public override int ObtenerLimiteReservasSemanales()
        {
            return 3;
        }
    }
}
