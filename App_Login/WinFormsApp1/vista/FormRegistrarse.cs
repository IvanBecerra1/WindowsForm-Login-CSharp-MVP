using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.vista.Interfaz;

namespace WinFormsApp1.vista
{
    public partial class FormRegistrarse : Form, IRegistrarseForm
    {
        private bool verificarRegistro;

        public FormRegistrarse()
        {
            InitializeComponent();
            InitializeEvents();
        }

        public string TextNombre 
        {
            get => this.textBoxNombre.Text;
            set => this.textBoxNombre.Text = value;
        }
        public string TextUsuario 
        {
            get => this.textBoxUsuario.Text;
            set => this.textBoxUsuario.Text = value;
        }
        public string TextPassword 
        {
            get => this.textBoxPassword.Text;
            set => this.textBoxPassword.Text = value;
        }


        public bool VerificarRegistro 
        { 
            get => this.verificarRegistro;
            set => this.verificarRegistro = value;
        }

        public event EventHandler EventRegistrarse;

        public void InitializeEvents()
        {
            this.btnRegistrar.Click += delegate {
                EventRegistrarse?.Invoke(this, EventArgs.Empty);

                if (this.verificarRegistro)
                {
                    MessageBox.Show("Registro Exitoso", "Login", MessageBoxButtons.OK);
                    this.Close();
                }

            };


        }
    }
}
