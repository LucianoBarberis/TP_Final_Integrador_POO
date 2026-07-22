using System;
using System.Collections.Generic;
using System.Text;
using Tp_Integrador_Final.Enums;
using Tp_Integrador_Final.Interface.Implementacion;
using Tp_Integrador_Final.Modelos;

namespace Tp_Integrador_Final
{
    public static class GestorDeDatos
    {
        public static Usuario usuarioLogeado { get; set; }
        public static RepositorioArchivo<Usuario> RepositorioUsuarios { get; private set; }
        public static RepositorioArchivo<SalaDeReuniones> RepositorioSalas { get; private set; }
        public static RepositorioArchivo<Reserva> RepositorioReservas { get; private set; }

        public static void Inicializar()
        {
            InicializarUsuarios();
            InicializarSalas();
            InicializarReservas();
        }

        private static void InicializarUsuarios()
        {
            RepositorioUsuarios = new RepositorioArchivo<Usuario>(
                //Nombre de la DB
                "usuariosDB",
                //Serialización
                usuario => usuario.ToString(),
                //Deserialización
                linea =>
                {
                    var partes = linea.Split('|');
                    int id = int.Parse(partes[0]);
                    RolesEnum rol = (RolesEnum)int.Parse(partes[1]);
                    Usuario usuario;

                    if (partes[1] == "0")
                    {
                        usuario = new Administrador();
                    }
                    else if (partes[1] == "1")
                    {
                        usuario = new Gerente();
                    }
                    else if (partes[1] == "2")
                    {
                        usuario = new Empleado();
                    }
                    else
                    {
                        throw new Exception($"Rol desconocido: {partes[1]}");
                    }

                    usuario.Id = id;
                    usuario.Name = partes[2];
                    usuario.Password = partes[3];
                    usuario.TotalReservasSemana = int.Parse(partes[4]);
                    usuario.UltimaReserva = string.IsNullOrEmpty(partes[5])
                        ? null
                        : DateTime.Parse(partes[5]);
                    return usuario;
                },
                //Obtener ID
                usuario => usuario.Id
            );
        }

        private static void InicializarSalas()
        {
            RepositorioSalas = new RepositorioArchivo<SalaDeReuniones>(
                "salasDB",
                sala => sala.ToString(),
                linea =>
                {
                    var partes = linea.Split('|');
                    return new SalaDeReuniones
                    {
                        Id = int.Parse(partes[0]),
                        Nombre = partes[1],
                        Capacidad = int.Parse(partes[2]),
                        Ubicacion = partes[3],
                        Disponible = bool.Parse(partes[4]),
                        Equipamiento = partes[5]
                    };
                },
                sala => sala.Id
            );
        }

        private static void InicializarReservas()
        {
            RepositorioReservas = new RepositorioArchivo<Reserva>(
                "reservasDB",
                reserva => reserva.ToString(),
                linea =>
                {
                    var partes = linea.Split('|');
                    return new Reserva
                    {
                        Id = int.Parse(partes[0]),
                        SalaId = int.Parse(partes[1]),
                        UsuarioId = int.Parse(partes[2]),
                        FechaReserva = DateTime.Parse(partes[3]),
                        HoraInicio = TimeSpan.Parse(partes[4]),
                        HoraFin = TimeSpan.Parse(partes[5]),
                        Motivo = partes[6],
                        Estado = (ReservaEstadoEnum)int.Parse(partes[7])
                    };
                },
                reserva => reserva.Id
            );
        }
    }
}
