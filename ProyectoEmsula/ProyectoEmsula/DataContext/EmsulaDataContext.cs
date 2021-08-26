using ProyectoEmsula.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoEmsula.DataContext
{
    public class EmsulaDataContext : DbContext
    {
        public DbSet<Canal> Canals{ get; set; }
        public DbSet<CaracteristicaZona> CaracteristicaZonas{ get; set; }
        public DbSet<Ciudad> Ciudads{ get; set; }
        public DbSet<Compania> Companias{ get; set; }
        public DbSet<Departamento> Departamentos{ get; set; }
        public DbSet<DiaVisita> DiaVisitas{ get; set; }
        public DbSet<FormaAtencion> FormaAtencions{ get; set; }
        public DbSet<Gestion> Gestions{ get; set; }
        public DbSet<PuntoPos> PuntoPos{ get; set; }
        public DbSet<PuntoRejas> PuntoRejas{ get; set; }
        public DbSet<Ramo> Ramos{ get; set; }
        public DbSet<Segmentacion> Segmentacions{ get; set; }
        public DbSet<Segmento> Segmentos{ get; set; }
        public DbSet<Tamano> Tamanos{ get; set; }
        public DbSet<Territorio> Territorios{ get; set; }
        public DbSet<TipoCliente> TipoClientes{ get; set; }
        public DbSet<TipoEmpresa> TipoEmpresas{ get; set; }
        public DbSet<TipoReferencia> TipoReferencias{ get; set; }
        public DbSet<TipoZona> TipoZonas{ get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ZonaEntrega> ZonaEntregas{ get; set; }

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
