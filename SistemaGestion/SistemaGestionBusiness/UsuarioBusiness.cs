using System.Collections.Generic;

using SistemaGestionEntities; // Asegúrate de agregar esto
using SistemaGestionData; // También necesitas esto para acceder a UsuarioData
namespace SistemaGestionBusiness
{
    public static class UsuarioBusiness
    {
        public static void RegistrarUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }

        // Métodos adicionales para modificar y eliminar...
    }
}