using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolApp.Migrations
{
    public partial class models3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_Status_StatusID",
                table: "Appeal");

            migrationBuilder.DropIndex(
                name: "IX_Appeal_StatusID",
                table: "Appeal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Appeal_StatusID",
                table: "Appeal",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appeal_Status_StatusID",
                table: "Appeal",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
