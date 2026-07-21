using Tp_Integrador_Final.Enums;

namespace Tp_Integrador_Final.Modelos
{
    public class Gerente : Usuario
    {
        public Gerente()
        {
            Rol = RolesEnum.Gerente;
        }

        public override int ObtenerLimiteReservasSemanales()
        {
            return 10;
        }
    }
}
