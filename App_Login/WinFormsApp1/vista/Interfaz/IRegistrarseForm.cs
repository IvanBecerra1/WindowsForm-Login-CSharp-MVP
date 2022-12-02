using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.vista.Interfaz
{
    public interface IRegistrarseForm
    {
        public event EventHandler EventRegistrarse;

        public string TextNombre
        {
            get;
            set;
        }

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

        public bool VerificarRegistro
        {
            get;
            set;
        }
    }
}
