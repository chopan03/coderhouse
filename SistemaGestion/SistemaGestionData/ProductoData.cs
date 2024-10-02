using System.Collections.Generic;
using System.Linq;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public static class ProductoData
    {
        private static List<Producto> productos = new List<Producto>();

        public static void CrearProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public static List<Producto> ListarProductos()
        {
            return productos;
        }

        // Métodos adicionales para modificar y eliminar...
    }
}