using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.models.Repositorio;
using WinFormsApp1.vista.Interfaz;

namespace WinFormsApp1.vista
{
    public partial class FormPanel : Form, IPanelForm
    {
        public FormPanel()
        {
            InitializeComponent();
            InitializeEvents();
        }

        public event EventHandler EventIniciarSesion;
        public event EventHandler EventRegistrarse;

        public void InitializeEvents()
        {
            this.btnIniciarSesion.Click += delegate {
                EventIniciarSesion?.Invoke(this, EventArgs.Empty);
            };

            this.btnRegistrar.Click += delegate {
                EventRegistrarse?.Invoke(this, EventArgs.Empty);
            };
        }

        private void FormPanel_Load(object sender, EventArgs e)
        {
            
        }


        public void BindingSourceUsuarios(BindingSource usuariosBindingSource)
        {
            this.dataGridUsuarios.DataSource = usuariosBindingSource;
        }

    }
}
