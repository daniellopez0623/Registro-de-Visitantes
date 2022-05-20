using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroVst.Models;
using RegistroVst.Data;
using Microsoft.EntityFrameworkCore;

namespace RegistroVst.Data
{
    public class ApplicationDbContext : DbContext
    {
        //ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Visitante> Visitante { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Historial> Historial { get; set; }

    }
}
