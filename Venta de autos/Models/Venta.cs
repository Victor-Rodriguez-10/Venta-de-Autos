﻿using System.ComponentModel.DataAnnotations;

namespace Venta_de_autos.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        public DateOnly Fecha { get; set; }
        public int Num_recibo { get; set; }

        //claves foraneas
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }
        [Required]
        //[Precision(10, 2)]
        public decimal Total { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual Vehiculo? Vehiculos { get; set; }



    }
}
