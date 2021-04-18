using Microsoft.EntityFrameworkCore.Migrations;

namespace Fantastical_Events_2021.Data.Migrations
{
    public partial class someChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "Events");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActivityId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
