﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoEmsula.DataContext;

namespace ProyectoEmsula.Migrations
{
    [DbContext(typeof(EmsulaDataContext))]
    partial class EmsulaDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoEmsula.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorreoElectronico");

                    b.Property<string>("NombreCorto");

                    b.Property<string>("NombreLegalCliente");

                    b.Property<long>("NumeroIdentidad");

                    b.Property<long>("NumeroRTN");

                    b.Property<int>("TelefonoCasa");

                    b.Property<int>("TelefonoCelular");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProyectoEmsula.Models.Dato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("clienteid");

                    b.Property<int>("datoEmsulaid");

                    b.Property<int>("negocioid");

                    b.Property<int>("ubicacionid");

                    b.HasKey("Id");

                    b.HasIndex("clienteid");

                    b.HasIndex("datoEmsulaid");

                    b.HasIndex("negocioid");

                    b.HasIndex("ubicacionid");

                    b.ToTable("Datos");
                });

            modelBuilder.Entity("ProyectoEmsula.Models.DatoEmsula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoCanal");

                    b.Property<string>("CodigoTerritorio");

                    b.Property<string>("Compania");

                    b.Property<string>("DiasVisita");

                    b.Property<string>("FormaAtencion");

                    b.Property<int>("OrdenVisita");

                    b.Property<string>("Ramo");

                    b.Property<string>("Segmentacion");

                    b.Property<string>("Segmento");

                    b.Property<string>("TipoCliente");

                    b.Property<string>("TipoEmpresa");

                    b.Property<string>("TipoZona");

                    b.Property<string>("Tiporeferencia");

                    b.Property<string>("ZonaEntrega");

                    b.HasKey("Id");

                    b.ToTable("DatoEmsulas");
                });

            modelBuilder.Entity("ProyectoEmsula.Models.Negocio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FechaAperturaNegocio");

                    b.Property<string>("NombreNegocio");

                    b.Property<string>("PuntoPos");

                    b.Property<string>("PuntoRejas");

                    b.Property<string>("ReponsableNegocio");

                    b.Property<string>("TamanoNegocio");

                    b.Property<int>("TelefonoNegocio");

                    b.HasKey("Id");

                    b.ToTable("Negocios");
                });

            modelBuilder.Entity("ProyectoEmsula.Models.Ubicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avenida");

                    b.Property<string>("Barrio");

                    b.Property<string>("Bloque");

                    b.Property<string>("Calle");

                    b.Property<string>("CaracteristicaZona");

                    b.Property<string>("Ciudad");

                    b.Property<string>("Departamento");

                    b.Property<string>("Etapa");

                    b.Property<string>("NumeroCasa");

                    b.Property<string>("PuntoReferencia");

                    b.Property<string>("Zona");

                    b.HasKey("Id");

                    b.ToTable("Ubicaciones");
                });

            modelBuilder.Entity("ProyectoEmsula.Models.Usuario", b =>
                {
                    b.Property<string>("UsuarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("EstaActivo");

                    b.Property<string>("Permiso");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios","dbo");
                });

            modelBuilder.Entity("ProyectoEmsula.Models.Dato", b =>
                {
                    b.HasOne("ProyectoEmsula.Models.Cliente", "cliente")
                        .WithMany("datos")
                        .HasForeignKey("clienteid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProyectoEmsula.Models.DatoEmsula", "datoEmsula")
                        .WithMany("datos")
                        .HasForeignKey("datoEmsulaid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProyectoEmsula.Models.Negocio", "negocio")
                        .WithMany("datos")
                        .HasForeignKey("negocioid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProyectoEmsula.Models.Ubicacion", "ubicacion")
                        .WithMany("datos")
                        .HasForeignKey("ubicacionid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
