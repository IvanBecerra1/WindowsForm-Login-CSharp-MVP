using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.models.dto;
using WinFormsApp1.models.Repositorio;
using WinFormsApp1.models.servicios;
using WinFormsApp1.models.servicios.implementacion;
using WinFormsApp1.vista.Interfaz;

namespace WinFormsApp1.vista.Presentacion
{
    public class PanelPresentacion
    {
        private IPanelForm iForm;

        private BindingSource usuariosBindingSource;

        public PanelPresentacion(IPanelForm iForm)
        {
            this.iForm = iForm;

            this.usuariosBindingSource= new BindingSource();

            this.iForm.EventIniciarSesion += CatchEventIniciarSesion;
            this.iForm.EventRegistrarse += CatchEventRegistrarse;

            this.iForm.BindingSourceUsuarios(this.usuariosBindingSource);
        }

        /// <summary>
        /// Captura del evento al hacer click
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        public void CatchEventIniciarSesion(Object? obj, EventArgs e)
        {
            ILogin iLogin = new LoginImplementacion();
            ILoginForm iLoginForm = new FormLogin();
            new LoginPresentacion(iLoginForm, iLogin);
            ((Form)iLoginForm).ShowDialog();
        }

        /// <summary>
        /// Captura del evento al hacer click
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        public void CatchEventRegistrarse(Object? obj, EventArgs e)
        {
            ILogin iLogin = new LoginImplementacion();
            IRegistrarseForm iRegistroForm = new FormRegistrarse();
            new RegistroPresentacion(iRegistroForm, iLogin);

            ((Form)iRegistroForm).ShowDialog();
            ActualizarDataGrid();
        }
        /// <summary>
        /// Actualizacion de los datos del data grid
        /// que esta enlazado con el Binding source
        /// a la vez mapeamos con el DTO de usuarios
        /// para mostrar datos que requiera y no todos los campos
        /// que se lleva en la entidad Usuario.cs
        /// </summary>
        public void ActualizarDataGrid()
        {
            // Actualizacion
            this.usuariosBindingSource.DataSource = UsuarioDTO.MapperDTOList(Repositorio.Usuarios);
            this.usuariosBindingSource.ResetBindings(true);
        }

    }
}
