using Tp_Integrador_Final.Enums;

namespace Tp_Integrador_Final.Modelos
{
    public class Administrador : Usuario
    {
        public Administrador()
        {
            Rol = RolesEnum.Admin;
        }

        public override int ObtenerLimiteReservasSemanales()
        {
            return int.MaxValue;
        }

        public override bool PuedeCancelar(Reserva reserva)
        {
            return true;
        }
    }
}
