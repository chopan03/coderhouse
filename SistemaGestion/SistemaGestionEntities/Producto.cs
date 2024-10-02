namespace SistemaGestionEntities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }

        public Producto() { }
    }
}