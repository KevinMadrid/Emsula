using ProyectoEmsula.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoEmsula.DataContext
{
    public class EmsulaDataContext : DbContext
    {
        public DbSet<Negocio> Negocios{ get; set; }
        public DbSet<Cliente> Clientes{ get; set; }
        public DbSet<Ubicacion> Ubicaciones{ get; set; }
        public DbSet<DatoEmsula> DatoEmsulas{ get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Dato> Datos{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Server=KEVIN-PC;DataBase=Emsula;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
