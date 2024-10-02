using System.Collections.Generic;
using System.Linq;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class UsuarioData
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        public static void CrearUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public static List<Usuario> ListarUsuarios()
        {
            return usuarios;
        }

        // Métodos adicionales para modificar y eliminar...
    }
}