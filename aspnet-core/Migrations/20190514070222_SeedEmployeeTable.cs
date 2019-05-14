using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnet_core.Migrations
{
    public partial class SeedEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Catalog", "Department", "Email", "Name" },
                values: new object[] { 1, "Test", "Engg", "test@test.com", "John Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
