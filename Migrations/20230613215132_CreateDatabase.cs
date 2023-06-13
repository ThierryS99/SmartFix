using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFix.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maquina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoIdentificacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HorasFuncionamento = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maquina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ordemManutencao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SetorId = table.Column<int>(type: "int", nullable: false),
                    MaquinaId = table.Column<int>(type: "int", nullable: false),
                    HorasFuncionamento = table.Column<double>(type: "float", nullable: false),
                    DataHoraExecucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TempoExecucao = table.Column<double>(type: "float", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordemManutencao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ordemManutencao_Maquina_MaquinaId",
                        column: x => x.MaquinaId,
                        principalTable: "Maquina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordemManutencao_Setor_SetorId",
                        column: x => x.SetorId,
                        principalTable: "Setor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ordemManutencao_MaquinaId",
                table: "ordemManutencao",
                column: "MaquinaId");

            migrationBuilder.CreateIndex(
                name: "IX_ordemManutencao_SetorId",
                table: "ordemManutencao",
                column: "SetorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ordemManutencao");

            migrationBuilder.DropTable(
                name: "Maquina");

            migrationBuilder.DropTable(
                name: "Setor");
        }
    }
}
