using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhachSan.Migrations
{
    public partial class Test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ChucVu",
                keyColumn: "MaChucVu",
                keyValue: 1,
                column: "TenChucVu",
                value: "Quan Ly");

            migrationBuilder.UpdateData(
                table: "ChucVu",
                keyColumn: "MaChucVu",
                keyValue: 2,
                column: "TenChucVu",
                value: "Le Tan");

            migrationBuilder.UpdateData(
                table: "ChucVu",
                keyColumn: "MaChucVu",
                keyValue: 3,
                column: "TenChucVu",
                value: "Thu Ngan");

            migrationBuilder.UpdateData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: 2,
                column: "TenLoaiPhong",
                value: "Binh Thuong");

            migrationBuilder.UpdateData(
                table: "TinhTrangPhong",
                keyColumn: "MaTinhTrang",
                keyValue: 1,
                column: "TenTinhTrang",
                value: "Trong");

            migrationBuilder.UpdateData(
                table: "TinhTrangPhong",
                keyColumn: "MaTinhTrang",
                keyValue: 2,
                column: "TenTinhTrang",
                value: "Dat Dat");

            migrationBuilder.UpdateData(
                table: "TinhTrangPhong",
                keyColumn: "MaTinhTrang",
                keyValue: 3,
                column: "TenTinhTrang",
                value: "Dang Sua Chua");

            migrationBuilder.UpdateData(
                table: "TrangThaiDat",
                keyColumn: "MaTrangThai",
                keyValue: 1,
                column: "TenTrangThai",
                value: "Da Thanh Toan");

            migrationBuilder.UpdateData(
                table: "TrangThaiDat",
                keyColumn: "MaTrangThai",
                keyValue: 2,
                column: "TenTrangThai",
                value: "Chua Thanh Toan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ChucVu",
                keyColumn: "MaChucVu",
                keyValue: 1,
                column: "TenChucVu",
                value: "Quản Lý");

            migrationBuilder.UpdateData(
                table: "ChucVu",
                keyColumn: "MaChucVu",
                keyValue: 2,
                column: "TenChucVu",
                value: "Lễ Tân");

            migrationBuilder.UpdateData(
                table: "ChucVu",
                keyColumn: "MaChucVu",
                keyValue: 3,
                column: "TenChucVu",
                value: "Thu Ngân");

            migrationBuilder.UpdateData(
                table: "LoaiPhong",
                keyColumn: "MaLoaiPhong",
                keyValue: 2,
                column: "TenLoaiPhong",
                value: "Bình Thường");

            migrationBuilder.UpdateData(
                table: "TinhTrangPhong",
                keyColumn: "MaTinhTrang",
                keyValue: 1,
                column: "TenTinhTrang",
                value: "Trống");

            migrationBuilder.UpdateData(
                table: "TinhTrangPhong",
                keyColumn: "MaTinhTrang",
                keyValue: 2,
                column: "TenTinhTrang",
                value: "Đã Đặt");

            migrationBuilder.UpdateData(
                table: "TinhTrangPhong",
                keyColumn: "MaTinhTrang",
                keyValue: 3,
                column: "TenTinhTrang",
                value: "Đang sửa chữa");

            migrationBuilder.UpdateData(
                table: "TrangThaiDat",
                keyColumn: "MaTrangThai",
                keyValue: 1,
                column: "TenTrangThai",
                value: "Đã Thanh Toán");

            migrationBuilder.UpdateData(
                table: "TrangThaiDat",
                keyColumn: "MaTrangThai",
                keyValue: 2,
                column: "TenTrangThai",
                value: "Chưa thanh toán");
        }
    }
}
