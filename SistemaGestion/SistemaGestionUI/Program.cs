using System;
using SistemaGestionEntities;
using SistemaGestionBusiness;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Registrar Usuario");
            Console.WriteLine("2. Listar Usuarios");
            Console.WriteLine("3. Registrar Producto");
            Console.WriteLine("4. Listar Productos");
            Console.WriteLine("5. Salir\n");
            Console.Write("Seleccione una opción: ");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarUsuario();
                    break;
                case "2":
                    ListarUsuarios();
                    break;
                case "3":
                    RegistrarProducto();
                    break;
                case "4":
                    ListarProductos();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opción no válida.\n");
                    break;
            }
        }
    }

    static void RegistrarUsuario()
    {
        Console.Clear();

        var usuario = new Usuario();

        Console.Write("Nombre: ");
        usuario.Nombre = Console.ReadLine();

        Console.Write("Apellido: ");
        usuario.Apellido = Console.ReadLine();

        Console.Write("Nombre de Usuario: ");
        usuario.NombreUsuario = Console.ReadLine();

        Console.Write("Contraseña: ");
        usuario.Contraseña = Console.ReadLine();

        Console.Write("Email: ");
        usuario.Mail = Console.ReadLine();

        UsuarioBusiness.RegistrarUsuario(usuario);

        Console.WriteLine("Usuario registrado exitosamente.");

        Console.ReadKey();

        Console.Clear();
    }

    static void ListarUsuarios()
    {
        Console.Clear();

        var usuarios = UsuarioBusiness.ObtenerUsuarios();

        if (usuarios.Count == 0)
        {
            Console.WriteLine("No hay usuarios registrados.\n\nToca un tecla para volver al Menu Principal");

            Console.ReadKey();

            Console.Clear();

            return;            
        }

        foreach (var user in usuarios)
        {
            Console.WriteLine($"Nombre del Usuario{user.Nombre} {user.Apellido}\nUserName: {user.NombreUsuario}\nEmail: {user.Mail}\n");

            Console.ReadKey();

            Console.Clear();
        }

        
    }

    static void RegistrarProducto()
    {
        Console.Clear();

        var producto = new Producto();

        Console.WriteLine("Nombre: ");
        producto.Name = Console.ReadLine();

        Console.Write("Descripción: ");
        producto.Descripcion = Console.ReadLine();

        Console.Write("Costo: ");
        producto.Costo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Precio de Venta: ");
        producto.PrecioVenta = Convert.ToDouble(Console.ReadLine());

        Console.Write("Stock: ");
        producto.Stock = Convert.ToInt32(Console.ReadLine());

        ProductoBusiness.RegistrarProducto(producto);

        Console.WriteLine("Producto registrado exitosamente.\n\nToca un tecla para volver al Menu Principal");

        Console.ReadKey();

        Console.Clear();
    }

    static void ListarProductos()
    {
        Console.Clear();

        var productos = ProductoBusiness.ObtenerProductos();

        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos registrados.\n\nToca un tecla para volver al Menu Principal");

            Console.ReadKey();

            Console.Clear();

            return;
        }

        foreach (var prod in productos)
        {
            Console.WriteLine($"Nombre del producto: {prod.Name}\nDescripcion: {prod.Descripcion}\nPrecio: {prod.PrecioVenta}\nStock: {prod.Stock}\n");

            Console.ReadKey();

            Console.Clear();
        }
    }
}