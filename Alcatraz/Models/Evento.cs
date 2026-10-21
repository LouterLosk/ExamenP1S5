using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Alcatraz.Models
{
    public class Evento
    {
        [Key]   
        public int Id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string genero { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Range(0,100)]
        public int aforo { get; set; }
        [Required]
        public string estado { get; set; }
        public virtual ICollection <Evento> EventoId { get; set; }
    }
}