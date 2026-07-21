using System;

namespace Tp_Integrador_Final.Excepciones
{
    public class ArchivoDatosCorruptoException : Exception
    {
        public ArchivoDatosCorruptoException() : base("El archivo de datos está corrupto o tiene un formato inválido.") { }

        public ArchivoDatosCorruptoException(string message) : base(message) { }

        public ArchivoDatosCorruptoException(string message, Exception inner) : base(message, inner) { }
    }
}
