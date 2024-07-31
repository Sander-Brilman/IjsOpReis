using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IjsOpReis.Migrations
{
    /// <inheritdoc />
    public partial class addedEndDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Distances");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndedAt",
                table: "Distances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndedAt",
                table: "Distances");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Distances",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}
