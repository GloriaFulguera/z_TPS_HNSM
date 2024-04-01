using System.Diagnostics;

namespace PSR_VentaEntradas_CopaAmerica
{
    internal static class Program //Aca nose porque tengo que transformar el internal static -> public, nose como hacer lo que quiuero 
                                  //manteniendo la visibilidad que viene por defecto
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static List<Cliente> misClientes = new List<Cliente>();
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Debug.WriteLine("CANTIDAD DE ELEMENTOS EN LA LISTA: " + misClientes.Count);
            Application.Run(new Principal());
        }
    }
}