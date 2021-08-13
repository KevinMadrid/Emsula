using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoEmsula.Migrations
{
    public partial class CrearDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroIdentidad = table.Column<long>(nullable: false),
                    NumeroRTN = table.Column<long>(nullable: false),
                    NombreLegalCliente = table.Column<string>(nullable: true),
                    NombreCorto = table.Column<string>(nullable: true),
                    TelefonoCasa = table.Column<int>(nullable: false),
                    TelefonoCelular = table.Column<int>(nullable: false),
                    CorreoElectronico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatoEmsulas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Compania = table.Column<string>(nullable: true),
                    Ramo = table.Column<string>(nullable: true),
                    Segmentacion = table.Column<string>(nullable: true),
                    Segmento = table.Column<string>(nullable: true),
                    TipoCliente = table.Column<string>(nullable: true),
                    FormaAtencion = table.Column<string>(nullable: true),
                    TipoEmpresa = table.Column<string>(nullable: true),
                    Tiporeferencia = table.Column<string>(nullable: true),
                    TipoZona = table.Column<string>(nullable: true),
                    CodigoCanal = table.Column<string>(nullable: true),
                    CodigoTerritorio = table.Column<string>(nullable: true),
                    ZonaEntrega = table.Column<string>(nullable: true),
                    DiasVisita = table.Column<string>(nullable: true),
                    OrdenVisita = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatoEmsulas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Negocios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreNegocio = table.Column<string>(nullable: true),
                    ReponsableNegocio = table.Column<string>(nullable: true),
                    TelefonoNegocio = table.Column<int>(nullable: false),
                    TamanoNegocio = table.Column<string>(nullable: true),
                    PuntoRejas = table.Column<string>(nullable: true),
                    PuntoPos = table.Column<string>(nullable: true),
                    FechaAperturaNegocio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negocios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Departamento = table.Column<string>(nullable: true),
                    Ciudad = table.Column<string>(nullable: true),
                    Zona = table.Column<string>(nullable: true),
                    Barrio = table.Column<string>(nullable: true),
                    CaracteristicaZona = table.Column<string>(nullable: true),
                    Calle = table.Column<string>(nullable: true),
                    Avenida = table.Column<string>(nullable: true),
                    Bloque = table.Column<string>(nullable: true),
                    Etapa = table.Column<string>(nullable: true),
                    NumeroCasa = table.Column<string>(nullable: true),
                    PuntoReferencia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                schema: "dbo",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(nullable: false),
                    Contrasenia = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Permiso = table.Column<string>(nullable: true),
                    EstaActivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Datos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    clienteid = table.Column<int>(nullable: false),
                    datoEmsulaid = table.Column<int>(nullable: false),
                    negocioid = table.Column<int>(nullable: false),
                    ubicacionid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Datos_Clientes_clienteid",
                        column: x => x.clienteid,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Datos_DatoEmsulas_datoEmsulaid",
                        column: x => x.datoEmsulaid,
                        principalTable: "DatoEmsulas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Datos_Negocios_negocioid",
                        column: x => x.negocioid,
                        principalTable: "Negocios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Datos_Ubicaciones_ubicacionid",
                        column: x => x.ubicacionid,
                        principalTable: "Ubicaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Datos_clienteid",
                table: "Datos",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Datos_datoEmsulaid",
                table: "Datos",
                column: "datoEmsulaid");

            migrationBuilder.CreateIndex(
                name: "IX_Datos_negocioid",
                table: "Datos",
                column: "negocioid");

            migrationBuilder.CreateIndex(
                name: "IX_Datos_ubicacionid",
                table: "Datos",
                column: "ubicacionid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datos");

            migrationBuilder.DropTable(
                name: "Usuarios",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "DatoEmsulas");

            migrationBuilder.DropTable(
                name: "Negocios");

            migrationBuilder.DropTable(
                name: "Ubicaciones");
        }
    }
}
