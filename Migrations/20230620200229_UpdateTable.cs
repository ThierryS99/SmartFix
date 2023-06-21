using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFix.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdemManutencao",
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
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusNumero = table.Column<int>(type: "int", nullable: false),
                    TipoNumero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemManutencao", x => x.Id);
                });
        }
    }
}
