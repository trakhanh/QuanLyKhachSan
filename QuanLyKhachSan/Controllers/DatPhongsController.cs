using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Controllers
{
    public class DatPhongsController : Controller
    {
        private readonly QuanLyKhachSanContext _context;

        public DatPhongsController(QuanLyKhachSanContext context)
        {
            _context = context;
        }

        // GET: DatPhongs
        public async Task<IActionResult> Index()
        {
            var quanLyKhachSanContext = _context.DatPhongs.Include(d => d.MaKhachHangNavigation).Include(d => d.MaNhanVienNavigation).Include(d => d.MaPhongNavigation).Include(d => d.MaTrangThaiNavigation);
            return View(await quanLyKhachSanContext.ToListAsync());
        }

        // GET: DatPhongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhong = await _context.DatPhongs
                .Include(d => d.MaKhachHangNavigation)
                .Include(d => d.MaNhanVienNavigation)
                .Include(d => d.MaPhongNavigation)
                .Include(d => d.MaTrangThaiNavigation)
                .FirstOrDefaultAsync(m => m.MaDatPhong == id);
            if (datPhong == null)
            {
                return NotFound();
            }

            return View(datPhong);
        }

        // GET: DatPhongs/Create
        public IActionResult Create()
        {
            ViewData["MaKhachHang"] = new SelectList(_context.KhachHangs, "MaKhachHang", "HoTen");
            ViewData["MaNhanVien"] = new SelectList(_context.NhanViens, "MaNhanVien", "HoTen");
            ViewData["MaPhong"] = new SelectList(_context.Phongs, "MaPhong", "TenPhong");
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThaiDats, "MaTrangThai", "TenTrangThai");
            return View();
        }

        // POST: DatPhongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaKhachHang,MaPhong,NgayBatDau,NgayKetThuc,SoNgayThue,ThanhTien,MaNhanVien,MaTrangThai")] DatPhong datPhong)
        {
            if (ModelState.IsValid)
            {
                if (datPhong.NgayBatDau != null && datPhong.NgayKetThuc != null)
                {
                    datPhong.SoNgayThue = (int)(datPhong.NgayKetThuc - datPhong.NgayBatDau).TotalDays;
                }
                else
                {
                    // Set a default value if the calculation is not possible
                    datPhong.SoNgayThue = 1;
                }

                _context.Add(datPhong);
                await _context.SaveChangesAsync();
                var phong = await _context.Phongs.FindAsync(datPhong.MaPhong);
                if (phong != null)
                {
                    phong.MaTinhTrang = 2; // Thay "DaDat" bằng mã trạng thái tương ứng với "đã đặt" trong cơ sở dữ liệu của bạn
                    _context.Update(phong);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKhachHang"] = new SelectList(_context.KhachHangs, "MaKhachHang", "HoTen", datPhong.MaKhachHang);
            ViewData["MaNhanVien"] = new SelectList(_context.NhanViens, "MaNhanVien", "HoTen", datPhong.MaNhanVien);
            ViewData["MaPhong"] = new SelectList(_context.Phongs, "MaPhong", "TenPhong", datPhong.MaPhong);
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThaiDats, "MaTrangThai", "TenTrangThai", datPhong.MaTrangThai);
            return View(datPhong);
        }

        // GET: DatPhongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhong = await _context.DatPhongs.FindAsync(id);
            if (datPhong == null)
            {
                return NotFound();
            }
            ViewData["MaKhachHang"] = new SelectList(_context.KhachHangs, "MaKhachHang", "HoTen", datPhong.MaKhachHang);
            ViewData["MaNhanVien"] = new SelectList(_context.NhanViens, "MaNhanVien", "HoTen", datPhong.MaNhanVien);
            ViewData["MaPhong"] = new SelectList(_context.Phongs, "MaPhong", "TenPhong", datPhong.MaPhong);
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThaiDats, "MaTrangThai", "TenTrangThai", datPhong.MaTrangThai);
            return View(datPhong);
        }

        // POST: DatPhongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaDatPhong,MaKhachHang,MaPhong,NgayBatDau,NgayKetThuc,SoNgayThue,ThanhTien,MaNhanVien,MaTrangThai")] DatPhong datPhong)
        {
            if (id != datPhong.MaDatPhong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(datPhong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatPhongExists(datPhong.MaDatPhong))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKhachHang"] = new SelectList(_context.KhachHangs, "MaKhachHang", "HoTen", datPhong.MaKhachHang);
            ViewData["MaNhanVien"] = new SelectList(_context.NhanViens, "MaNhanVien", "HoTen", datPhong.MaNhanVien);
            ViewData["MaPhong"] = new SelectList(_context.Phongs, "MaPhong", "TenPhong", datPhong.MaPhong);
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThaiDats, "MaTrangThai", "TenTrangThai", datPhong.MaTrangThai);
            return View(datPhong);
        }

        // GET: DatPhongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var datPhong = await _context.DatPhongs
                .Include(d => d.MaKhachHangNavigation)
                .Include(d => d.MaNhanVienNavigation)
                .Include(d => d.MaPhongNavigation)
                .Include(d => d.MaTrangThaiNavigation)
                .FirstOrDefaultAsync(m => m.MaDatPhong == id);
            if (datPhong == null)
            {
                return NotFound();
            }

            return View(datPhong);
        }

        // POST: DatPhongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var datPhong = await _context.DatPhongs.FindAsync(id);
            _context.DatPhongs.Remove(datPhong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatPhongExists(int id)
        {
            return _context.DatPhongs.Any(e => e.MaDatPhong == id);
        }
    }
}
