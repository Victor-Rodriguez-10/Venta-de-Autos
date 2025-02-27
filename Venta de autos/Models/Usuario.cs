using System.ComponentModel.DataAnnotations;
using Venta_de_autos.Datos;
namespace Venta_de_autos.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Pasword { get; set; }
        public RolEnum Rol { get; set; }

        public virtual List<Venta>? Ventas { get; set; }
    }
}
