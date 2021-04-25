using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class _updatebookings3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BookingsHistory_CabTypeId",
                table: "BookingsHistory",
                column: "CabTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingsHistory_FromPlace",
                table: "BookingsHistory",
                column: "FromPlace");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingsHistory_CabTypes_CabTypeId",
                table: "BookingsHistory",
                column: "CabTypeId",
                principalTable: "CabTypes",
                principalColumn: "CabTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookingsHistory_Places_FromPlace",
                table: "BookingsHistory",
                column: "FromPlace",
                principalTable: "Places",
                principalColumn: "PlaceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingsHistory_CabTypes_CabTypeId",
                table: "BookingsHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookingsHistory_Places_FromPlace",
                table: "BookingsHistory");

            migrationBuilder.DropIndex(
                name: "IX_BookingsHistory_CabTypeId",
                table: "BookingsHistory");

            migrationBuilder.DropIndex(
                name: "IX_BookingsHistory_FromPlace",
                table: "BookingsHistory");
        }
    }
}
