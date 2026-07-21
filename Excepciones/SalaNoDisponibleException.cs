using System;

namespace Tp_Integrador_Final.Excepciones
{
    public class SalaNoDisponibleException : Exception
    {
        public SalaNoDisponibleException() : base("La sala no está disponible para el horario solicitado.") { }

        public SalaNoDisponibleException(string message) : base(message) { }

        public SalaNoDisponibleException(string message, Exception inner) : base(message, inner) { }
    }
}
