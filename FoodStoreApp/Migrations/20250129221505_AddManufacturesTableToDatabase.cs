using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodStoreApp.Migrations
{
    /// <inheritdoc />
    public partial class AddManufacturesTableToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ManufacturerDescription",
                table: "Manufactures",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufacturerDescription",
                table: "Manufactures");
        }
    }
}
