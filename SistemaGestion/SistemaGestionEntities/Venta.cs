namespace SistemaGestionEntities
{
    public class Venta
    {
        public int Id { get; set; }
        public string Comentarios { get; set; } = string.Empty;
        public int IdUsuario { get; set; }

        public Venta() { }
    }
}