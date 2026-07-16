using Tp_Integrador_Final.Interface.Implementacion;
using Tp_Integrador_Final.Modelos;
using Tp_Integrador_Final.Enums;

namespace Tp_Integrador_Final
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Inicializamos el gestor de datos
            GestorDeDatos.Inicializar();
            Application.Run(new Login());
        }
    }
}