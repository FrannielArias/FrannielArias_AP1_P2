using FrannielArias_AP1_P2.Models;
using FrannielArias_AP1_P2.Services;
using Microsoft.EntityFrameworkCore;

namespace FrannielArias_AP1_P2.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
           : base(options) { }

        public DbSet<Registro> Registro { get; set; }
    }
}
