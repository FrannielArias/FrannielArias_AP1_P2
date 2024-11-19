using FrannielArias_AP1_P2.Models;
using FrannielArias_AP1_P2.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FrannielArias_AP1_P2.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
           : base(options) { }

        public DbSet<Articulos> Articulo { get; set; }

        public DbSet<Combos> Combo { get; set; }

        public DbSet<CombosDetalle> Detalles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulos>().HasData(
                new List<Articulos>()
                {
                new()
                {
                    Articuloid = 1,
                    Descripcion = "RAM",
                    precio =200,
                },
                new()
                {
                    Articuloid = 2,
                    Descripcion = "Procesador",
                    precio =2000,
                },
                new() 
                {
                    Articuloid = 3,
                    Descripcion = "Disco Duro",
                    precio =2500,
                }, 
                new()
                {
                    Articuloid = 4,
                    Descripcion = "Targeta Grafica",
                    precio =2500,
                }
                }
            );
            base.OnModelCreating(modelBuilder);
        }

    }
}
