﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Venta_de_autos.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        public string? Matricula { get; set; }
        public string? Modelo { get; set; }
        public int Stock { get; set; }

        // para el archivo de la foto 
        [NotMapped]
        [Display(Name = "Cargar Foto")]
        public IFormFile? FotoFile { get; set; }
        // 
        [NotMapped]
        public string? Inf { get { return $"{Matricula} - {Modelo}"; } }
        [Required]
        //[Precision(20, 6)]
        public decimal CostoVehiculo { get; set; }
        public string? Descripsion { get; set; }
        public string? UrlFoto { get; set; }
    }
}
