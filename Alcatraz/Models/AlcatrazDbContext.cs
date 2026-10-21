using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Alcatraz.Models
{
    public class AlcatrazDbContext:DbContext
    {
        public AlcatrazDbContext() :base ("name=AlcatrazDbContext") { }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}