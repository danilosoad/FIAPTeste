using Microsoft.EntityFrameworkCore.Migrations;

namespace FIAP.Migrations
{
    public partial class TabeladeLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SALT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADMIN = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Login",
                columns: new[] { "ID", "ADMIN", "PASSWORD", "SALT", "USERNAME" },
                values: new object[] { 1, true, "scMR1rXjMMPCxLR35LfrTk0s9Xti8IsCk1/W0VuAyfY=", "Lp/VYJDCuUrK8FZsYO2+4A==", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");
        }
    }
}
