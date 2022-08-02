using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataaccessLayer.Migrations
{
    public partial class firstmigratons333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Rezervations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Rezervations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
