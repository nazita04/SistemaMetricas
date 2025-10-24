namespace SistemaMetricas.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Dni { get; set; }
        public string Area { get; set; }
        public string FechaAlta { get; set; }
        public string Estado { get; set; }

        public string Rol { get; set; }

        public Roles Roles { get; set; }  
    }
}