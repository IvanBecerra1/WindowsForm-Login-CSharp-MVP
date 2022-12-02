using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.models.servicios
{
    /// <summary>
    /// Firma de los metodos que se llevan a cabo
    /// </summary>
    public interface ILogin
    {

        public bool Login(string username, string password);

        public bool registrar(string nombre, string username, string password);

    }
}
