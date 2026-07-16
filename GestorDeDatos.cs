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
        public static RepositorioArchivo<Usuario> RepositorioUsuarios { get; private set; }

        public static void Inicializar()
        {
            RepositorioUsuarios = new RepositorioArchivo<Usuario>(
                //Nombre de la DB
                "usuariosDB",
                //Serialización
                usuario => $"{usuario.Id}|{(int)usuario.Rol}|{usuario.Name}|{usuario.Password}|{usuario.TotalReservasSemana}|{usuario.UltimaReserva?.ToString("yyyy-MM-dd") ?? ""}",
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
    }
}
