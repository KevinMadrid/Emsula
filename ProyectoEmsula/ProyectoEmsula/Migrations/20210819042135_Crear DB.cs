using System;
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
                name: "Canals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoCanal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaracteristicaZonas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaracteristicadeZona = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaracteristicaZonas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CiudadNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompañiaNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartamentoNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiaVisitas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DiasVisita = table.Column<string>(nullable: true),
                    OrdenVisita = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaVisitas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaAtencions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FormaAtencionCliente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaAtencions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PuntoPos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PuntoconPos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntoPos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PuntoRejas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PuntoconRejas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntoRejas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ramos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RamoNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ramos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Segmentacions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SegmentacionNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segmentacions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Segmentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SegmentoNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segmentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tamanos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TamanoNegocio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tamanos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Territorios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoTerritorio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territorios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoClientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoClienteContable = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoClientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEmpresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoEmpresaLegal = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEmpresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoReferencias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tiporeferencia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoReferencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoZonas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoZonaNombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoZonas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZonaEntregas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ZonadeEntrega = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZonaEntregas", x => x.Id);
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
                name: "Gestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroIdentidad = table.Column<long>(nullable: false),
                    NumeroRTN = table.Column<long>(nullable: false),
                    NombreLegalCliente = table.Column<string>(nullable: true),
                    NombreCorto = table.Column<string>(nullable: true),
                    NombreNegocio = table.Column<string>(nullable: true),
                    ReponsableNegocio = table.Column<string>(nullable: true),
                    FechaAperturaNegocio = table.Column<DateTime>(nullable: false),
                    companiaid = table.Column<int>(nullable: false),
                    departamentoid = table.Column<int>(nullable: false),
                    ciudadid = table.Column<int>(nullable: false),
                    Zona = table.Column<string>(nullable: true),
                    Barrio = table.Column<string>(nullable: true),
                    caracteristicaZonaid = table.Column<int>(nullable: false),
                    Calle = table.Column<string>(nullable: true),
                    Avenida = table.Column<string>(nullable: true),
                    Bloque = table.Column<string>(nullable: true),
                    Etapa = table.Column<string>(nullable: true),
                    NumeroCasa = table.Column<int>(nullable: false),
                    PuntoReferencia = table.Column<string>(nullable: true),
                    TelefonoNegocio = table.Column<int>(nullable: false),
                    TelefonoCasa = table.Column<int>(nullable: false),
                    TelefonoCelular = table.Column<int>(nullable: false),
                    CorreoElectronico = table.Column<string>(nullable: true),
                    ramoid = table.Column<int>(nullable: false),
                    segmentacionid = table.Column<int>(nullable: false),
                    segmentoid = table.Column<int>(nullable: false),
                    tipoEmpresaid = table.Column<int>(nullable: false),
                    tipoReferenciaid = table.Column<int>(nullable: false),
                    tipoZonaid = table.Column<int>(nullable: false),
                    tamanoid = table.Column<int>(nullable: false),
                    puntoRejasid = table.Column<int>(nullable: false),
                    puntoPosid = table.Column<int>(nullable: false),
                    tipoClienteid = table.Column<int>(nullable: false),
                    formaAtencionid = table.Column<int>(nullable: false),
                    canalid = table.Column<int>(nullable: false),
                    territorioid = table.Column<int>(nullable: false),
                    zonaEntregaid = table.Column<int>(nullable: false),
                    diaVisitaid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gestions_Canals_canalid",
                        column: x => x.canalid,
                        principalTable: "Canals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_CaracteristicaZonas_caracteristicaZonaid",
                        column: x => x.caracteristicaZonaid,
                        principalTable: "CaracteristicaZonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_Ciudads_ciudadid",
                        column: x => x.ciudadid,
                        principalTable: "Ciudads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_Companias_companiaid",
                        column: x => x.companiaid,
                        principalTable: "Companias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_Departamentos_departamentoid",
                        column: x => x.departamentoid,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_DiaVisitas_diaVisitaid",
                        column: x => x.diaVisitaid,
                        principalTable: "DiaVisitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_FormaAtencions_formaAtencionid",
                        column: x => x.formaAtencionid,
                        principalTable: "FormaAtencions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_PuntoPos_puntoPosid",
                        column: x => x.puntoPosid,
                        principalTable: "PuntoPos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_PuntoRejas_puntoRejasid",
                        column: x => x.puntoRejasid,
                        principalTable: "PuntoRejas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_Ramos_ramoid",
                        column: x => x.ramoid,
                        principalTable: "Ramos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_Segmentacions_segmentacionid",
                        column: x => x.segmentacionid,
                        principalTable: "Segmentacions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_Segmentos_segmentoid",
                        column: x => x.segmentoid,
                        principalTable: "Segmentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_Tamanos_tamanoid",
                        column: x => x.tamanoid,
                        principalTable: "Tamanos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_Territorios_territorioid",
                        column: x => x.territorioid,
                        principalTable: "Territorios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_TipoClientes_tipoClienteid",
                        column: x => x.tipoClienteid,
                        principalTable: "TipoClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_TipoEmpresas_tipoEmpresaid",
                        column: x => x.tipoEmpresaid,
                        principalTable: "TipoEmpresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_TipoReferencias_tipoReferenciaid",
                        column: x => x.tipoReferenciaid,
                        principalTable: "TipoReferencias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_TipoZonas_tipoZonaid",
                        column: x => x.tipoZonaid,
                        principalTable: "TipoZonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gestions_ZonaEntregas_zonaEntregaid",
                        column: x => x.zonaEntregaid,
                        principalTable: "ZonaEntregas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_canalid",
                table: "Gestions",
                column: "canalid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_caracteristicaZonaid",
                table: "Gestions",
                column: "caracteristicaZonaid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_ciudadid",
                table: "Gestions",
                column: "ciudadid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_companiaid",
                table: "Gestions",
                column: "companiaid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_departamentoid",
                table: "Gestions",
                column: "departamentoid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_diaVisitaid",
                table: "Gestions",
                column: "diaVisitaid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_formaAtencionid",
                table: "Gestions",
                column: "formaAtencionid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_puntoPosid",
                table: "Gestions",
                column: "puntoPosid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_puntoRejasid",
                table: "Gestions",
                column: "puntoRejasid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_ramoid",
                table: "Gestions",
                column: "ramoid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_segmentacionid",
                table: "Gestions",
                column: "segmentacionid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_segmentoid",
                table: "Gestions",
                column: "segmentoid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_tamanoid",
                table: "Gestions",
                column: "tamanoid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_territorioid",
                table: "Gestions",
                column: "territorioid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_tipoClienteid",
                table: "Gestions",
                column: "tipoClienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_tipoEmpresaid",
                table: "Gestions",
                column: "tipoEmpresaid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_tipoReferenciaid",
                table: "Gestions",
                column: "tipoReferenciaid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_tipoZonaid",
                table: "Gestions",
                column: "tipoZonaid");

            migrationBuilder.CreateIndex(
                name: "IX_Gestions_zonaEntregaid",
                table: "Gestions",
                column: "zonaEntregaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gestions");

            migrationBuilder.DropTable(
                name: "Usuarios",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Canals");

            migrationBuilder.DropTable(
                name: "CaracteristicaZonas");

            migrationBuilder.DropTable(
                name: "Ciudads");

            migrationBuilder.DropTable(
                name: "Companias");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "DiaVisitas");

            migrationBuilder.DropTable(
                name: "FormaAtencions");

            migrationBuilder.DropTable(
                name: "PuntoPos");

            migrationBuilder.DropTable(
                name: "PuntoRejas");

            migrationBuilder.DropTable(
                name: "Ramos");

            migrationBuilder.DropTable(
                name: "Segmentacions");

            migrationBuilder.DropTable(
                name: "Segmentos");

            migrationBuilder.DropTable(
                name: "Tamanos");

            migrationBuilder.DropTable(
                name: "Territorios");

            migrationBuilder.DropTable(
                name: "TipoClientes");

            migrationBuilder.DropTable(
                name: "TipoEmpresas");

            migrationBuilder.DropTable(
                name: "TipoReferencias");

            migrationBuilder.DropTable(
                name: "TipoZonas");

            migrationBuilder.DropTable(
                name: "ZonaEntregas");
        }
    }
}
