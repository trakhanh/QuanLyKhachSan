using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhachSan.Migrations
{
    public partial class AddDuLieuTV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TenTrangThai",
                table: "TrangThaiDat",
                type: "nvarchar(MAX)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "HoTen",
                table: "NhanVien",
                type: "nvarchar(MAX)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "NhanVien",
                type: "nvarchar(MAX)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "TenLoaiPhong",
                table: "LoaiPhong",
                type: "nvarchar(MAX)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "HoTen",
                table: "KhachHang",
                type: "nvarchar(MAX)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "KhachHang",
                type: "nvarchar(MAX)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "TenChucVu",
                table: "ChucVu",
                type: "nvarchar(MAX)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TenTrangThai",
                table: "TrangThaiDat",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "HoTen",
                table: "NhanVien",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "NhanVien",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "TenLoaiPhong",
                table: "LoaiPhong",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "HoTen",
                table: "KhachHang",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DiaChi",
                table: "KhachHang",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "TenChucVu",
                table: "ChucVu",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)",
                oldUnicode: false,
                oldMaxLength: 50);

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
                value: "Da Dat");

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
    }
}
