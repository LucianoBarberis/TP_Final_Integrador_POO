using System;
using System.Collections.Generic;
using System.Text;

namespace Tp_Integrador_Final.Interface
{
    public interface IRepository<T> where T : class
    {
        void Agregar(T entidad);
        T Obtener(int id);
        List<T> Listar();
        void Actualizar(T entidad);
        bool Eliminar(int id);
    }
}
