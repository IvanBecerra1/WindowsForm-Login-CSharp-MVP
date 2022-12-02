using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.vista.Interfaz
{
    public interface IPanelForm
    {
        public event EventHandler EventIniciarSesion;
        public event EventHandler EventRegistrarse;

        public void BindingSourceUsuarios(BindingSource usuariosBindingSource);
    }
}
