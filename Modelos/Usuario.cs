using System;
using System.Security.Cryptography;
using System.Text;
using Tp_Integrador_Final.Enums;

namespace Tp_Integrador_Final.Modelos
{
    public abstract class Usuario
    {
        private int id = RandomNumberGenerator.GetInt32(1000000, 9999999);
        private RolesEnum rol;
        private string name;
        private string password;
        private int totalReservasSemana = 0;
        private DateTime? ultimaReserva;

        public int Id { get => id; set => id = value; }
        public RolesEnum Rol { get => rol; set => rol = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public int TotalReservasSemana { get => totalReservasSemana; set => totalReservasSemana = value; }
        public DateTime? UltimaReserva { get => ultimaReserva; set => ultimaReserva = value; }

        public abstract int ObtenerLimiteReservasSemanales();

        public virtual bool PuedeCancelar(Reserva reserva)
        {
            return reserva.UsuarioId == Id;
        }

        public override string ToString()
        {
            return $"{Id}|{(int)Rol}|{Name}|{Password}|{TotalReservasSemana}|{UltimaReserva?.ToString("yyyy-MM-dd") ?? ""}";
        }
    }
}
