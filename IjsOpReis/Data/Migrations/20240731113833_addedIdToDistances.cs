using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IjsOpReis.Migrations
{
    /// <inheritdoc />
    public partial class addedIdToDistances : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Distances",
                table: "Distances");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Distances",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distances",
                table: "Distances",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Distances",
                table: "Distances");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Distances");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distances",
                table: "Distances",
                column: "StartedAt");
        }
    }
}
