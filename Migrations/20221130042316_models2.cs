using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolApp.Migrations
{
    public partial class models2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StatusID",
                table: "AppealStatus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StatusID",
                table: "Appeal",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Application_SchoolID",
                table: "Application",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_AppealStatus_StatusID",
                table: "AppealStatus",
                column: "StatusID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AppealStatus_Status_StatusID",
                table: "AppealStatus",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Application_School_SchoolID",
                table: "Application",
                column: "SchoolID",
                principalTable: "School",
                principalColumn: "SchoolID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appeal_Status_StatusID",
                table: "Appeal");

            migrationBuilder.DropForeignKey(
                name: "FK_AppealStatus_Status_StatusID",
                table: "AppealStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_School_SchoolID",
                table: "Application");

            migrationBuilder.DropIndex(
                name: "IX_Application_SchoolID",
                table: "Application");

            migrationBuilder.DropIndex(
                name: "IX_AppealStatus_StatusID",
                table: "AppealStatus");

            migrationBuilder.DropIndex(
                name: "IX_Appeal_StatusID",
                table: "Appeal");

            migrationBuilder.AlterColumn<int>(
                name: "StatusID",
                table: "AppealStatus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StatusID",
                table: "Appeal",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
