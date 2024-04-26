using ApiCoreCubos.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace ApiCoreCubos.Data
{
    public class CubosContext: DbContext
    {
      
        public CubosContext(DbContextOptions<CubosContext> options) : base(options) { }

        public DbSet<Cubo> Cubos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        
    }
}
