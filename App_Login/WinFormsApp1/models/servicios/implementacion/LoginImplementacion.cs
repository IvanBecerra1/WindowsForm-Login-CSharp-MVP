using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.models.entidad;
using WinFormsApp1.models.Repositorio;

namespace WinFormsApp1.models.servicios.implementacion
{
    /// <summary>
    /// Implementacion del comportamiento de los metodos que tiene la interfaz
    /// 
    /// </summary>
    public class LoginImplementacion : ILogin
    {
        public bool Login(string username, string password)
        {
            Usuario usuario = new Usuario(password, username);
            return Repositorio.Repositorio.Usuarios.Contains(usuario);
        }

        public bool registrar(string nombre, string username, string password)
        {
            validacion(nombre, username, password);

            Usuario usuario = new Usuario();

            usuario.Nombre = nombre;
            usuario.Password = password;
            usuario.User = username;

            Repositorio.Repositorio.Usuarios.Add(usuario);

            return true;
        }

        public void validacion(string nombre, string username, string password)
        {
            if (String.IsNullOrEmpty(nombre))
                throw new Exception("Nombre vacio, ingrese uno");

            if (String.IsNullOrEmpty(password))
                throw new Exception("Password vacio, ingrese uno");

            if (String.IsNullOrEmpty(password))
                throw new Exception("Usuario vacio, ingrese uno");

            if (Repositorio.Repositorio.Usuarios.Find(aux => aux.Nombre == nombre) is not null)
                throw new Exception("Ese usuario ya existe, ingrese uno diferente");
        }
    }
}
