using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Integrador_Final.Interface.Implementacion
{
    public class RepositorioArchivo<T> : IRepository<T> where T : class
    {
        private static readonly string DirectorioBase =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\DataBase");
        private readonly string _rutaArchivo;
        private readonly Func<T, string> _serializar;
        private readonly Func<string, T> _deserializar;
        private readonly Func<T, int> _obtenerId;

        public RepositorioArchivo(
            string nombreArchivo,
            Func<T, string> serializar,
            Func<string, T> deserializar,
            Func<T, int> obtenerId)
        {
            _rutaArchivo = Path.Combine(DirectorioBase, $"{nombreArchivo}.txt");
            _serializar = serializar;
            _deserializar = deserializar;
            _obtenerId = obtenerId;

            InicializarArchivo();
        }

        private void InicializarArchivo()
        {
            string directorio = Path.GetDirectoryName(_rutaArchivo);
            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);

            if (!File.Exists(_rutaArchivo))
                File.Create(_rutaArchivo).Close();
        }

        public void Agregar(T entidad)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_rutaArchivo, true))
                {
                    string linea = _serializar(entidad);
                    sw.WriteLine(linea);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar en {_rutaArchivo}", ex);
            }
        }

        public T Obtener(int id)
        {
            return Listar().FirstOrDefault(e => _obtenerId(e) == id);
        }

        public List<T> Listar()
        {
            var lista = new List<T>();
            try
            {
                using (StreamReader sr = new StreamReader(_rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue;
                        try
                        {
                            T entidad = _deserializar(linea);
                            if (entidad != null)
                                lista.Add(entidad);
                        }
                        catch
                        {
                            throw new Exception(
                                $"Línea corrupta en {_rutaArchivo}: '{linea}'");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer {_rutaArchivo}", ex);
            }
            return lista;
        }

        public void Actualizar(T entidad)
        {
            var lista = Listar();
            int id = _obtenerId(entidad);
            var index = lista.FindIndex(e => _obtenerId(e) == id);
            if (index >= 0)
            {
                lista[index] = entidad;
                GuardarTodo(lista);
            }
        }

        public bool Eliminar(int id)
        {
            var lista = Listar();
            var item = lista.FirstOrDefault(e => _obtenerId(e) == id);
            if (item != null)
            {
                lista.Remove(item);
                GuardarTodo(lista);
                return true;
            }
            return false;
        }

        private void GuardarTodo(List<T> lista)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_rutaArchivo, false))
                {
                    foreach (var item in lista)
                    {
                        sw.WriteLine(_serializar(item));
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO: Crear excepción personalizada para errores de escritura en archivo
                throw new Exception($"Error al escribir en {_rutaArchivo}", ex);
            }
        }
    }
}
