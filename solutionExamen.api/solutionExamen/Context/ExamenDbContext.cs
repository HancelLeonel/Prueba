using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using solutionExamen.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solutionExamen.Context
{
    public class ExamenDbContext:DbContext
    {
        public ExamenDbContext(DbContextOptions<ExamenDbContext> Options):base(Options)
        {

        }

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }


    }
}
