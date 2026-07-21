using System;

namespace Tp_Integrador_Final.Excepciones
{
    public class ReservaSolapadaException : Exception
    {
        public ReservaSolapadaException() : base("La reserva se superpone con otra existente en el mismo horario.") { }

        public ReservaSolapadaException(string message) : base(message) { }

        public ReservaSolapadaException(string message, Exception inner) : base(message, inner) { }
    }
}
