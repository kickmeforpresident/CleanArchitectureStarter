using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Content", "UserId" },
                values: new object[] { 1, "First", null });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Content", "UserId" },
                values: new object[] { 2, "Second", null });

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "Content", "UserId" },
                values: new object[] { 3, "Third", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
