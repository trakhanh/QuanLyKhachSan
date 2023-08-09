using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class QuanLyKhachSanContext : DbContext
    {
        public QuanLyKhachSanContext()
        {
        }

        public QuanLyKhachSanContext(DbContextOptions<QuanLyKhachSanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DatPhong> DatPhongs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TinhTrangPhong> TinhTrangPhongs { get; set; }
        public virtual DbSet<TrangThaiDat> TrangThaiDats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=GIAKHANH;Database=QLKSAN;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiPhong>().HasData(
            new LoaiPhong { MaLoaiPhong = 1, TenLoaiPhong = "VIP" },
            new LoaiPhong { MaLoaiPhong = 2, TenLoaiPhong = "Binh Thuong" }
            );
            modelBuilder.Entity<ChucVu>().HasData(
            new ChucVu { MaChucVu = 1, TenChucVu = "Quan Ly" },
            new ChucVu { MaChucVu = 2, TenChucVu = "Le Tan" },
            new ChucVu { MaChucVu = 3, TenChucVu = "Thu Ngan" }
            );
            modelBuilder.Entity<TinhTrangPhong>().HasData(
            new TinhTrangPhong { MaTinhTrang = 1, TenTinhTrang = "Trong" },
            new TinhTrangPhong { MaTinhTrang = 2, TenTinhTrang = "Da Dat" },
            new TinhTrangPhong { MaTinhTrang = 3, TenTinhTrang = "Dang Sua Chua" }
            );
            modelBuilder.Entity<TrangThaiDat>().HasData(
            new TrangThaiDat { MaTrangThai = 1, TenTrangThai = "Da Thanh Toan" },
            new TrangThaiDat { MaTrangThai = 2, TenTrangThai = "Chua Thanh Toan" } 
            );
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.MaChucVu)
                    .HasName("PK__ChucVu__D463953333E1199E");

                entity.ToTable("ChucVu");

                entity.Property(e => e.MaChucVu).ValueGeneratedNever();

                entity.Property(e => e.TenChucVu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DatPhong>(entity =>
            {
                entity.HasKey(e => e.MaDatPhong)
                    .HasName("PK__DatPhong__6344ADEABD7ACFA4");

                entity.ToTable("DatPhong");

                entity.Property(e => e.MaDatPhong);

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.DatPhongs)
                    .HasForeignKey(d => d.MaKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DatPhong__MaKhac__47DBAE45");

                entity.HasOne(d => d.MaNhanVienNavigation)
                    .WithMany(p => p.DatPhongs)
                    .HasForeignKey(d => d.MaNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DatPhong__MaNhan__49C3F6B7");

                entity.HasOne(d => d.MaPhongNavigation)
                    .WithMany(p => p.DatPhongs)
                    .HasForeignKey(d => d.MaPhong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DatPhong__MaPhon__48CFD27E");

                entity.HasOne(d => d.MaTrangThaiNavigation)
                    .WithMany(p => p.DatPhongs)
                    .HasForeignKey(d => d.MaTrangThai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DatPhong__MaTran__4AB81AF0");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang)
                    .HasName("PK__KhachHan__88D2F0E50D94392D");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKhachHang);

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<LoaiPhong>(entity =>
            {
                entity.HasKey(e => e.MaLoaiPhong)
                    .HasName("PK__LoaiPhon__230212173274457F");

                entity.ToTable("LoaiPhong");

                entity.Property(e => e.MaLoaiPhong).ValueGeneratedNever();

                entity.Property(e => e.TenLoaiPhong)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNhanVien)
                    .HasName("PK__NhanVien__77B2CA4742399806");

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNhanVien);

                entity.Property(e => e.DiaChi)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TaiKhoan)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.MaChucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__MaChuc__398D8EEE");
            });

            modelBuilder.Entity<Phong>(entity =>
            {
                entity.HasKey(e => e.MaPhong)
                    .HasName("PK__Phong__20BD5E5BCC8A63C0");

                entity.ToTable("Phong");

                entity.Property(e => e.MaPhong);

                entity.HasOne(d => d.MaLoaiPhongNavigation)
                    .WithMany(p => p.Phongs)
                    .HasForeignKey(d => d.MaLoaiPhong)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Phong__MaLoaiPho__4222D4EF");

                entity.HasOne(d => d.MaTinhTrangNavigation)
                    .WithMany(p => p.Phongs)
                    .HasForeignKey(d => d.MaTinhTrang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Phong__MaTinhTra__4316F928");
            });

            modelBuilder.Entity<TinhTrangPhong>(entity =>
            {
                entity.HasKey(e => e.MaTinhTrang)
                    .HasName("PK__TinhTran__89F8F669AEA3EA50");

                entity.ToTable("TinhTrangPhong");

                entity.Property(e => e.MaTinhTrang).ValueGeneratedNever();

                entity.Property(e => e.TenTinhTrang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrangThaiDat>(entity =>
            {
                entity.HasKey(e => e.MaTrangThai)
                    .HasName("PK__TrangTha__AADE413819F5FC56");

                entity.ToTable("TrangThaiDat");

                entity.Property(e => e.MaTrangThai).ValueGeneratedNever();

                entity.Property(e => e.TenTrangThai)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
