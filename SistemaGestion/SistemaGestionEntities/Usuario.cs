﻿namespace SistemaGestionEntities
{
    public class Usuario
    {
        public int Id { get; set; } 
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;
        public string Contraseña { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
        public Usuario() { }
    }
}