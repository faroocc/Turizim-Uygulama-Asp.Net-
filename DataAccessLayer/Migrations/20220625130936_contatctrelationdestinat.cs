using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataaccessLayer.Migrations
{
    public partial class contatctrelationdestinat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinationID",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_DestinationID",
                table: "Contacts",
                column: "DestinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Destinations_DestinationID",
                table: "Contacts",
                column: "DestinationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Destinations_DestinationID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_DestinationID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "Contacts");
        }
    }
}
