using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.models.servicios;
using WinFormsApp1.vista.Interfaz;

namespace WinFormsApp1.vista.Presentacion
{
    /// <summary>
    /// Clase destinada a llevar a logica que se utiliza en el formulario
    /// </summary>
    public class LoginPresentacion
    {
        private ILoginForm iLogin;
        private ILogin iLoginService;

        public LoginPresentacion(ILoginForm iLogin, ILogin iLoginService)
        {
            this.iLogin = iLogin;
            this.iLoginService = iLoginService;

            this.iLogin.EventIniciarSesion += CatchEventIniciarSesion;
        }
        /// <summary>
        /// Captura del evento al hacer click
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        public void CatchEventIniciarSesion(Object? obj, EventArgs e)
        {
            try
            {
                string usuario = this.iLogin.TextUsuario;
                string password = this.iLogin.TextPassword;

                this.iLogin.VerificarLogin = this.iLoginService.Login(usuario, password);
            } catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
