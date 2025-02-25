using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Venta_de_autos.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Celular { get; set; }
        public int Ci { get; set; }
        public string? Direccion { get; set; }

        [NotMapped]
        public string? Inf { get { return $"{Direccion} - {Nombre} - {Ci} - {Celular}"; } }

        public virtual List<Venta>? Ventas { get; set; }
    }
}
