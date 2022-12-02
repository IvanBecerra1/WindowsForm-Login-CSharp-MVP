using System;

using WinFormsApp1.models.entidad;

namespace WinFormsApp1.models.dto
{
    /// <summary>
    /// Data Transfer Object
    /// 
    /// Un patron destinado a la transeferencia de datos
    /// para evitar obtener datos que no quisieramos
    /// </summary>
    public class UsuarioDTO
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public static UsuarioDTO Mapper(Usuario usuario)
        {
            UsuarioDTO userDTO = new UsuarioDTO();

            userDTO.id= usuario.Id;
            userDTO.nombre= usuario.Nombre;

            return userDTO;
        }

        public static List<UsuarioDTO> MapperDTOList(List<Usuario> usuarios)
        {
            List<UsuarioDTO> listDTO = new List<UsuarioDTO>();

            foreach (Usuario usuarioAux in usuarios)
            {
                listDTO.Add(UsuarioDTO.Mapper(usuarioAux));
            }
            return listDTO;
        }
    }
}
