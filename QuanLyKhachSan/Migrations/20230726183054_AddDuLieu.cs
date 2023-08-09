using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhachSan.Migrations
{
    public partial class AddDuLieu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ChucVu",
                columns: new[] { "MaChucVu", "TenChucVu" },
                values: new object[,]
                {
                    { 1, "Quan Ly" },
                    { 2, "Le Tan" },
                    { 3, "Thu Ngan" }
                });

            migrationBuilder.InsertData(
                table: "LoaiPhong",
                columns: new[] { "MaLoaiPhong", "DonGia", "TenLoaiPhong" },
                values: new object[,]
                {
                    { 1, 0, "VIP" },
                    { 2, 0, "Binh Thuong" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChucVu",
                keyColumn: "MaChucVu",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ChucVu",
                keyColumn: "MaChucVu",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ChucVu",
                keyColumn: "MaChucVu",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: 2);
        }
    }
}
