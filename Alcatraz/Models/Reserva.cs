using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Alcatraz.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NombreCliente { get; set; }
        [Required]
        public string TipoMesa { get; set; }
        [Required]
        public int NumeroPersonas { get; set; }
        [Required]
        public decimal ValorTotal { get; set; }
        [Required]
        public int EventoId { get; set; }

    }
}