using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.models.entidad
{
    public class Usuario
    {
        private int id;
        private static int idCount;

        private string nombre;
        private string user;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }
        public string User { get => user; set => user = value; }

        public Usuario() {
            this.id = Usuario.idCount++;
            this.password = "";
            this.user = "";
            this.nombre = "";
        }
        public Usuario(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Usuario(string password, string user) : this()
        {
            this.password = password;
            this.user = user;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj is not Usuario)
                return false;

            return this == ((Usuario)obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"nombre: {this.nombre} - usuario: {this.user} - password: {this.password}";
        }
        public static bool operator ==(Usuario usuarioA, Usuario usuarioB)
        {
            return usuarioA.user == usuarioB.user && usuarioA.password == usuarioB.password;
        }

        public static bool operator !=(Usuario usuarioA, Usuario usuarioB)
        {
            return !(usuarioA == usuarioB);
        }
    }
}
