using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IjsOpReis.Migrations
{
    /// <inheritdoc />
    public partial class changedTypesOfDistancesAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Distances_Year",
                table: "Distances");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Distances");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartedAt",
                table: "Distances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Distances",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Distances",
                table: "Distances",
                column: "StartedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Distances",
                table: "Distances");

            migrationBuilder.DropColumn(
                name: "StartedAt",
                table: "Distances");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Distances");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Distances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Distances_Year",
                table: "Distances",
                column: "Year",
                unique: true);
        }
    }
}
