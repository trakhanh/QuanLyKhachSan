using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhachSan.Migrations
{
    public partial class AddDuLieu1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TinhTrangPhong",
                columns: new[] { "MaTinhTrang", "TenTinhTrang" },
                values: new object[] { 1, "Trong" });

            migrationBuilder.InsertData(
                table: "TinhTrangPhong",
                columns: new[] { "MaTinhTrang", "TenTinhTrang" },
                values: new object[] { 2, "Da Dat" });

            migrationBuilder.InsertData(
                table: "TinhTrangPhong",
                columns: new[] { "MaTinhTrang", "TenTinhTrang" },
                values: new object[] { 3, "Dang Sua Chua" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TinhTrangPhong",
                keyColumn: "MaTinhTrang",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TinhTrangPhong",
                keyColumn: "MaTinhTrang",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TinhTrangPhong",
                keyColumn: "MaTinhTrang",
                keyValue: 3);
        }
    }
}
