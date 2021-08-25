using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorAdminTemplate.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "809868e2-6775-481d-b688-2b843475da7b", "9fb4869b-3fa7-4d26-a7cf-850999a594a8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b13fd533-6db2-4a1a-b5e6-b116ad94fdcc", "418a877e-7101-4f26-a403-27d5d9032ee8", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "809868e2-6775-481d-b688-2b843475da7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b13fd533-6db2-4a1a-b5e6-b116ad94fdcc");
        }
    }
}
