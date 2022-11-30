using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftLearn.Migrations
{
    public partial class tesr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goat", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Goat_FullName",
                table: "Goat",
                column: "FullName",
                unique: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goat");
        }
    }
}
