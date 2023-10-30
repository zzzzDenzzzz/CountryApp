using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CountryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddPartOfTheWorld : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartsOfTheWorld",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartsOfTheWorld",
                table: "Countries");
        }
    }
}
