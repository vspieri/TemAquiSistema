using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tem_Aqui.Migrations
{
    /// <inheritdoc />
    public partial class Criacaoinicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestador",
                columns: table => new
                {
                    IdPrestador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePrestador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestador", x => x.IdPrestador);
                });

            migrationBuilder.CreateTable(
                name: "TabelClientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndereçoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelClientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "SerPres",
                columns: table => new
                {
                    SerPresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrestadordeservicoId = table.Column<int>(type: "int", nullable: false),
                    DataEHr = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Preço = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerPres", x => x.SerPresId);
                    table.ForeignKey(
                        name: "FK_SerPres_Prestador_PrestadordeservicoId",
                        column: x => x.PrestadordeservicoId,
                        principalTable: "Prestador",
                        principalColumn: "IdPrestador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SerPres_PrestadordeservicoId",
                table: "SerPres",
                column: "PrestadordeservicoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SerPres");

            migrationBuilder.DropTable(
                name: "TabelClientes");

            migrationBuilder.DropTable(
                name: "Prestador");
        }
    }
}
