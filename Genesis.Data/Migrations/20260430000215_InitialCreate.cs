using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Genesis.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemActividades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreItemActividad = table.Column<string>(type: "TEXT", nullable: false),
                    Unidad = table.Column<string>(type: "TEXT", nullable: false),
                    DescripcionItemActividad = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemActividades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecursoUnitarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreRecursoUnitario = table.Column<string>(type: "TEXT", nullable: false),
                    Unidad = table.Column<string>(type: "TEXT", nullable: false),
                    TipoRecurso = table.Column<string>(type: "TEXT", nullable: false),
                    Agrupador = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValorUnitarioBruto = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecursoUnitarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposCosto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescripcionTipoCosto = table.Column<string>(type: "TEXT", nullable: false),
                    AbreTipoCosto = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCosto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposRecurso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescripcionTipoRecurso = table.Column<string>(type: "TEXT", nullable: false),
                    AbrTipoRecurso = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposRecurso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadesMedida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescripcionUnidad = table.Column<string>(type: "TEXT", nullable: false),
                    AbreUnidad = table.Column<string>(type: "TEXT", nullable: false),
                    TipoMedida = table.Column<string>(type: "TEXT", nullable: false),
                    UnidadRef = table.Column<string>(type: "TEXT", nullable: false),
                    UnidadConversion = table.Column<float>(type: "REAL", nullable: false),
                    Esref = table.Column<bool>(type: "INTEGER", nullable: false),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesMedida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    NombrePila = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    Rol = table.Column<int>(type: "INTEGER", nullable: false),
                    EstaActivo = table.Column<bool>(type: "INTEGER", nullable: false),
                    UltimoIngreso = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaestroPptos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombrePlantilla = table.Column<string>(type: "TEXT", nullable: false),
                    AbrePlantillaPPto = table.Column<string>(type: "TEXT", nullable: false),
                    VersionPlantilla = table.Column<string>(type: "TEXT", nullable: false),
                    NivelEstructuraPlantilla = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoCostoPlantillaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaestroPptos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaestroPptos_TiposCosto_TipoCostoPlantillaId",
                        column: x => x.TipoCostoPlantillaId,
                        principalTable: "TiposCosto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agrupadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreAgrupador = table.Column<string>(type: "TEXT", nullable: false),
                    DescripAgrupador = table.Column<string>(type: "TEXT", nullable: false),
                    AplicaIVA = table.Column<bool>(type: "INTEGER", nullable: false),
                    ValorIVA = table.Column<decimal>(type: "TEXT", nullable: false),
                    EsIVADescontable = table.Column<bool>(type: "INTEGER", nullable: false),
                    TipoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agrupadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agrupadores_TiposRecurso_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TiposRecurso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImpuestosTaxes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DescripcionImpuesto = table.Column<string>(type: "TEXT", nullable: false),
                    ValorImpuesto = table.Column<decimal>(type: "TEXT", nullable: false),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Naturaleza = table.Column<int>(type: "INTEGER", nullable: false),
                    AgrupadorId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImpuestosTaxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImpuestosTaxes_Agrupadores_AgrupadorId",
                        column: x => x.AgrupadorId,
                        principalTable: "Agrupadores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agrupadores_TipoId",
                table: "Agrupadores",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_ImpuestosTaxes_AgrupadorId",
                table: "ImpuestosTaxes",
                column: "AgrupadorId");

            migrationBuilder.CreateIndex(
                name: "IX_MaestroPptos_TipoCostoPlantillaId",
                table: "MaestroPptos",
                column: "TipoCostoPlantillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImpuestosTaxes");

            migrationBuilder.DropTable(
                name: "ItemActividades");

            migrationBuilder.DropTable(
                name: "MaestroPptos");

            migrationBuilder.DropTable(
                name: "RecursoUnitarios");

            migrationBuilder.DropTable(
                name: "UnidadesMedida");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Agrupadores");

            migrationBuilder.DropTable(
                name: "TiposCosto");

            migrationBuilder.DropTable(
                name: "TiposRecurso");
        }
    }
}
