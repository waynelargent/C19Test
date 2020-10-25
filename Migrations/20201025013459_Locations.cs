using Microsoft.EntityFrameworkCore.Migrations;

namespace C19Test.Migrations
{
    public partial class Locations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Cases",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationDescription = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cases_LocationID",
                table: "Cases",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Location_LocationID",
                table: "Cases",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Location_LocationID",
                table: "Cases");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Cases_LocationID",
                table: "Cases");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Cases");
        }
    }
}
