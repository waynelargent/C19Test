using Microsoft.EntityFrameworkCore.Migrations;

namespace C19Test.Migrations
{
    public partial class StatusDesc2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Status_Cases_CaseID",
                table: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Status_CaseID",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "CaseID",
                table: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_Cases_StatusID",
                table: "Cases",
                column: "StatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Status_StatusID",
                table: "Cases",
                column: "StatusID",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Status_StatusID",
                table: "Cases");

            migrationBuilder.DropIndex(
                name: "IX_Cases_StatusID",
                table: "Cases");

            migrationBuilder.AddColumn<int>(
                name: "CaseID",
                table: "Status",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Status_CaseID",
                table: "Status",
                column: "CaseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Status_Cases_CaseID",
                table: "Status",
                column: "CaseID",
                principalTable: "Cases",
                principalColumn: "CaseID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
