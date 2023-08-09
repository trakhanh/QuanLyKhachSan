using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhachSan.Migrations
{
    public partial class AddDuLieu2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TrangThaiDat",
                columns: new[] { "MaTrangThai", "TenTrangThai" },
                values: new object[] { 1, "Da Thanh Toan" });

            migrationBuilder.InsertData(
                table: "TrangThaiDat",
                columns: new[] { "MaTrangThai", "TenTrangThai" },
                values: new object[] { 2, "Chua Thanh Toan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrangThaiDat",
                keyColumn: "MaTrangThai",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrangThaiDat",
                keyColumn: "MaTrangThai",
                keyValue: 2);
        }
    }
}
