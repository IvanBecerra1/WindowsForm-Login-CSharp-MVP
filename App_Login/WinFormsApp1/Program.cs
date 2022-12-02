using WinFormsApp1.vista;
using WinFormsApp1.vista.Interfaz;
using WinFormsApp1.vista.Presentacion;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            IPanelForm iPanelForm = new FormPanel();
            new PanelPresentacion(iPanelForm);

            Application.Run(((Form)iPanelForm));
        }
    }
}