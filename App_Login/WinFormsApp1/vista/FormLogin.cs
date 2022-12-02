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
    public partial class FormLogin : Form, ILoginForm
    {
        private bool verificarLogin;

        public FormLogin()
        {
            InitializeComponent();
            InitializeEvents();
        }

        public string TextUsuario {
            get => this.textBoxUsuario.Text;
            set => this.textBoxUsuario.Text = value;
        }
        public string TextPassword { 
            get => this.textBoxPassword.Text;
            set => this.textBoxPassword.Text = value;
        }

        public bool VerificarLogin { 
            get => this.verificarLogin; 
            set => this.verificarLogin = value;
        }

        public event EventHandler EventIniciarSesion;


        public void InitializeEvents()
        {
            this.btnIniciarSesion.Click += delegate { 
                EventIniciarSesion?.Invoke(this, EventArgs.Empty);

                if (this.verificarLogin)
                {
                    MessageBox.Show("Logeo Exitoso", "Login", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos", "Login", MessageBoxButtons.OK);
                }

            };

            
        }
    }
}
