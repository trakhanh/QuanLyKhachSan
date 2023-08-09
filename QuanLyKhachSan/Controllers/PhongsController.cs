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
    public class PhongsController : Controller
    {
        private readonly QuanLyKhachSanContext _context;

        public PhongsController(QuanLyKhachSanContext context)
        {
            _context = context;
        }

        // GET: Phongs
        public async Task<IActionResult> Index()
        {
            var quanLyKhachSanContext = _context.Phongs.Include(p => p.MaLoaiPhongNavigation).Include(p => p.MaTinhTrangNavigation);
            return View(await quanLyKhachSanContext.ToListAsync());
        }

        // GET: Phongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.Phongs
                .Include(p => p.MaLoaiPhongNavigation)
                .Include(p => p.MaTinhTrangNavigation)
                .FirstOrDefaultAsync(m => m.MaPhong == id);
            if (phong == null)
            {
                return NotFound();
            }

            return View(phong);
        }

        // GET: Phongs/Create
        public IActionResult Create()
        {

            ViewData["MaLoaiPhong"] = new SelectList(_context.LoaiPhongs, "MaLoaiPhong", "TenLoaiPhong");
            ViewData["MaTinhTrang"] = new SelectList(_context.TinhTrangPhongs, "MaTinhTrang", "TenTinhTrang");
            return View();

        }

        // POST: Phongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TenPhong,MaLoaiPhong,MaTinhTrang")] Phong phong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaLoaiPhong"] = new SelectList(_context.LoaiPhongs, "MaLoaiPhong", "TenLoaiPhong", phong.MaLoaiPhong);
            ViewData["MaTinhTrang"] = new SelectList(_context.TinhTrangPhongs, "MaTinhTrang", "TenTinhTrang", phong.MaTinhTrang);
            return View(phong);
        }


        // GET: Phongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.Phongs.FindAsync(id);
            if (phong == null)
            {
                return NotFound();
            }
            ViewData["MaLoaiPhong"] = new SelectList(_context.LoaiPhongs, "MaLoaiPhong", "TenLoaiPhong", phong.MaLoaiPhong);
            ViewData["MaTinhTrang"] = new SelectList(_context.TinhTrangPhongs, "MaTinhTrang", "TenTinhTrang", phong.MaTinhTrang);
            return View(phong);
        }

        // POST: Phongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaPhong,TenPhong,MaLoaiPhong,MaTinhTrang")] Phong phong)
        {
            if (id != phong.MaPhong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhongExists(phong.MaPhong))
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
            ViewData["MaLoaiPhong"] = new SelectList(_context.LoaiPhongs, "MaLoaiPhong", "TenLoaiPhong", phong.MaLoaiPhong);
            ViewData["MaTinhTrang"] = new SelectList(_context.TinhTrangPhongs, "MaTinhTrang", "TenTinhTrang", phong.MaTinhTrang);
            return View(phong);
        }

        // GET: Phongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phong = await _context.Phongs
                .Include(p => p.MaLoaiPhongNavigation)
                .Include(p => p.MaTinhTrangNavigation)
                .FirstOrDefaultAsync(m => m.MaPhong == id);
            if (phong == null)
            {
                return NotFound();
            }

            return View(phong);
        }

        // POST: Phongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phong = await _context.Phongs.FindAsync(id);
            _context.Phongs.Remove(phong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhongExists(int id)
        {
            return _context.Phongs.Any(e => e.MaPhong == id);
        }
    }
}
