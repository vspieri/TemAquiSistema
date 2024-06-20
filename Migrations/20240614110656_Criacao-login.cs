using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tem_Aqui.Migrations
{
    /// <inheritdoc />
    public partial class Criacaologin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoginSenha",
                table: "Login",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoginSenha",
                table: "Login");
        }
    }
}
