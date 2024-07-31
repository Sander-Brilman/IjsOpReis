using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IjsOpReis.Migrations
{
    /// <inheritdoc />
    public partial class addedDistances : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distances",
                columns: table => new
                {
                    Year = table.Column<long>(type: "bigint", nullable: false),
                    Kilometers = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Distances_Year",
                table: "Distances",
                column: "Year",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Distances");
        }
    }
}
