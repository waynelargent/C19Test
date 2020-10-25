using Microsoft.EntityFrameworkCore.Migrations;

namespace C19Test.Migrations
{
    public partial class StatusDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaseID",
                table: "Status",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
