using Microsoft.EntityFrameworkCore.Migrations;

namespace RoadTrip.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travelers_AspNetUsers_IdentityUserId",
                table: "Travelers");

            migrationBuilder.DropIndex(
                name: "IX_Travelers_IdentityUserId",
                table: "Travelers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d790e3cd-e144-418c-bc6d-d3f4e293e4fa");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Travelers");

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "68a70286-5694-431f-a12e-b6002d64a128", "1d8e1279-3d84-44e6-b235-ea2e7da77c7a", "Traveler", "Traveler" });

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_IdentityUserId",
                table: "Profiles",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68a70286-5694-431f-a12e-b6002d64a128");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Travelers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d790e3cd-e144-418c-bc6d-d3f4e293e4fa", "e2242cd7-66d5-47c7-9e24-4afee3be51bb", "Traveler", "Traveler" });

            migrationBuilder.CreateIndex(
                name: "IX_Travelers_IdentityUserId",
                table: "Travelers",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Travelers_AspNetUsers_IdentityUserId",
                table: "Travelers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
