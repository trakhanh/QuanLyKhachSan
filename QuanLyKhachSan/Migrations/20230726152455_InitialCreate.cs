using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyKhachSan.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    MaChucVu = table.Column<int>(type: "int", nullable: false),
                    TenChucVu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChucVu__D463953333E1199E", x => x.MaChucVu);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: false),
                    DiaChi = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    SDT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KhachHan__88D2F0E50D94392D", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhong",
                columns: table => new
                {
                    MaLoaiPhong = table.Column<int>(type: "int", nullable: false),
                    TenLoaiPhong = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LoaiPhon__230212173274457F", x => x.MaLoaiPhong);
                });

            migrationBuilder.CreateTable(
                name: "TinhTrangPhong",
                columns: table => new
                {
                    MaTinhTrang = table.Column<int>(type: "int", nullable: false),
                    TenTinhTrang = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TinhTran__89F8F669AEA3EA50", x => x.MaTinhTrang);
                });

            migrationBuilder.CreateTable(
                name: "TrangThaiDat",
                columns: table => new
                {
                    MaTrangThai = table.Column<int>(type: "int", nullable: false),
                    TenTrangThai = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TrangTha__AADE413819F5FC56", x => x.MaTrangThai);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaiKhoan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    HoTen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: false),
                    DiaChi = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    SDT = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    MaChucVu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NhanVien__77B2CA4742399806", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK__NhanVien__MaChuc__398D8EEE",
                        column: x => x.MaChucVu,
                        principalTable: "ChucVu",
                        principalColumn: "MaChucVu",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    MaPhong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaLoaiPhong = table.Column<int>(type: "int", nullable: false),
                    MaTinhTrang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Phong__20BD5E5BCC8A63C0", x => x.MaPhong);
                    table.ForeignKey(
                        name: "FK__Phong__MaLoaiPho__4222D4EF",
                        column: x => x.MaLoaiPhong,
                        principalTable: "LoaiPhong",
                        principalColumn: "MaLoaiPhong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Phong__MaTinhTra__4316F928",
                        column: x => x.MaTinhTrang,
                        principalTable: "TinhTrangPhong",
                        principalColumn: "MaTinhTrang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DatPhong",
                columns: table => new
                {
                    MaDatPhong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhachHang = table.Column<int>(type: "int", nullable: false),
                    MaPhong = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "date", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "date", nullable: false),
                    SoNgayThue = table.Column<int>(type: "int", nullable: false),
                    ThanhTien = table.Column<int>(type: "int", nullable: false),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    MaTrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DatPhong__6344ADEABD7ACFA4", x => x.MaDatPhong);
                    table.ForeignKey(
                        name: "FK__DatPhong__MaKhac__47DBAE45",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__DatPhong__MaNhan__49C3F6B7",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__DatPhong__MaPhon__48CFD27E",
                        column: x => x.MaPhong,
                        principalTable: "Phong",
                        principalColumn: "MaPhong",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__DatPhong__MaTran__4AB81AF0",
                        column: x => x.MaTrangThai,
                        principalTable: "TrangThaiDat",
                        principalColumn: "MaTrangThai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatPhong_MaKhachHang",
                table: "DatPhong",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_DatPhong_MaNhanVien",
                table: "DatPhong",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_DatPhong_MaPhong",
                table: "DatPhong",
                column: "MaPhong");

            migrationBuilder.CreateIndex(
                name: "IX_DatPhong_MaTrangThai",
                table: "DatPhong",
                column: "MaTrangThai");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaChucVu",
                table: "NhanVien",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_MaLoaiPhong",
                table: "Phong",
                column: "MaLoaiPhong");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_MaTinhTrang",
                table: "Phong",
                column: "MaTinhTrang");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatPhong");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "TrangThaiDat");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "LoaiPhong");

            migrationBuilder.DropTable(
                name: "TinhTrangPhong");
        }
    }
}
