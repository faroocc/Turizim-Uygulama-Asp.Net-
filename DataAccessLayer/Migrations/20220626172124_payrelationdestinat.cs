using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataaccessLayer.Migrations
{
    public partial class payrelationdestinat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    PayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaySurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayTotalPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayStatus = table.Column<bool>(type: "bit", nullable: false),
                    PayCreditNumber = table.Column<int>(type: "int", nullable: false),
                    PayCreditDate = table.Column<int>(type: "int", nullable: false),
                    PayCvc = table.Column<int>(type: "int", nullable: false),
                    DestinationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.PayID);
                    table.ForeignKey(
                        name: "FK_Pays_Destinations_DestinationID",
                        column: x => x.DestinationID,
                        principalTable: "Destinations",
                        principalColumn: "DestinationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pays_DestinationID",
                table: "Pays",
                column: "DestinationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pays");
        }
    }
}
