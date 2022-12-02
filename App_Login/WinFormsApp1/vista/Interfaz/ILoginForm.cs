using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.vista.Interfaz
{
    public interface ILoginForm
    {
        public event EventHandler EventIniciarSesion;

        public string TextUsuario
        {
            get; 
            set;
        }

        public string TextPassword
        {
            get;
            set;
        }

        public bool VerificarLogin
        {
            get;
            set;
        }
    }
}
