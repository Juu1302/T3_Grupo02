using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace T3_Grupo02.Migrations
{
    /// <inheritdoc />
    public partial class agregarBD_Grupo02_T3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tema = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    editorial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aniopublicacion = table.Column<int>(type: "int", nullable: false),
                    paginas = table.Column<int>(type: "int", nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libro");
        }
    }
}
