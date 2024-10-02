using System.Collections.Generic;

using SistemaGestionEntities; // Asegúrate de agregar esto
using SistemaGestionData; // También necesitas esto para acceder a UsuarioData

namespace SistemaGestionBusiness
{
    public static class ProductoBusiness
    {
        public static void RegistrarProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }

        public static List<Producto> ObtenerProductos()
        {
            return ProductoData.ListarProductos();
        }

        // Métodos adicionales para modificar y eliminar...
    }
}