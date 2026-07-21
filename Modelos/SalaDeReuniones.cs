using System.Security.Cryptography;

namespace Tp_Integrador_Final.Modelos
{
    public class SalaDeReuniones
    {
        private int id = RandomNumberGenerator.GetInt32(1000000, 9999999);
        private string nombre;
        private int capacidad;
        private string ubicacion;
        private string equipamiento;
        private bool disponible = true;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Equipamiento { get => equipamiento; set => equipamiento = value; }
        public bool Disponible { get => disponible; set => disponible = value; }

        public override string ToString()
        {
            return $"{Id}|{Nombre}|{Capacidad}|{Ubicacion}|{Equipamiento}|{Disponible}";
        }
    }
}
