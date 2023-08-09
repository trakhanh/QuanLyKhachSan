using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhachSan.Migrations
{
    public partial class Test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TinhTrangPhong",
                keyColumn: "MaTinhTrang",
                keyValue: 2,
                column: "TenTinhTrang",
                value: "Da Dat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TinhTrangPhong",
                keyColumn: "MaTinhTrang",
                keyValue: 2,
                column: "TenTinhTrang",
                value: "Dat Dat");
        }
    }
}
