using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.models.servicios;
using WinFormsApp1.vista.Interfaz;

namespace WinFormsApp1.vista.Presentacion
{
    public class RegistroPresentacion
    {

        private IRegistrarseForm iRegistro;
        private ILogin iLoginService;

        public RegistroPresentacion(IRegistrarseForm iRegistro, ILogin iLoginService)
        {
            this.iRegistro = iRegistro;
            this.iLoginService = iLoginService;


            this.iRegistro.EventRegistrarse += CatchEventRegistro;
        }
        /// <summary>
        /// Captura del evento al hacer click
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        public void CatchEventRegistro(object? sender, EventArgs e)
        {
            try
            {
                string nombre = this.iRegistro.TextNombre;
                string usuario = this.iRegistro.TextUsuario;
                string password = this.iRegistro.TextPassword; 

                this.iRegistro.VerificarRegistro = this.iLoginService.registrar(nombre, usuario, password);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
