
using Microsoft.EntityFrameworkCore;
using playkidsEntidades;

namespace playkidsAPI.Data
{
    public class DbContextSistema : DbContext
    {
        public DbContextSistema(DbContextOptions<DbContextSistema> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            modelBuilder.Entity<Usuario>().HasKey(u => u.IdUsuario);
        }


    }
}