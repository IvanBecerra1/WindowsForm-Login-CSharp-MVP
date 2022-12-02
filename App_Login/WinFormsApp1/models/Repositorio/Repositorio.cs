using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.models.entidad;

namespace WinFormsApp1.models.Repositorio
{
    /// <summary>
    /// Simulacion de una base de datos
    /// Estatica porque se comparte entre toda las clases existentes
    /// </summary>
    public static class Repositorio
    {
        private static List<Usuario> usuario;

        static Repositorio()
        {
            Repositorio.usuario = new List<Usuario>();

        }
        public static List<Usuario> Usuarios { get => usuario; set => usuario = value; }
    }
}
