using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UltimateFunCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBookingToDbUpdateColums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HowManyPeople",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HowMayMinors",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "HowManyPeople",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "HowMayMinors",
                table: "Bookings");
        }
    }
}
