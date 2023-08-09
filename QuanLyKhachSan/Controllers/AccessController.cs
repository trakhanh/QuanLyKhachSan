using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyKhachSan.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class AccessController : Controller
{
    private readonly QuanLyKhachSanContext _context;

    public AccessController(QuanLyKhachSanContext context)
    {
        _context = context;
    }

    // GET: Access/Login
    public IActionResult Login()
    {
        return View();
    }

    // POST: Access/Login
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(string taiKhoan, string matKhau)
    {
        if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
        {
            ViewBag.Message = "Vui lòng nhập tài khoản và mật khẩu.";
            return View();
        }

        var nhanVien = await _context.NhanViens.FirstOrDefaultAsync(nv => nv.TaiKhoan == taiKhoan && nv.MatKhau == matKhau);

        if (nhanVien == null)
        {
            ViewBag.Message = "Tài khoản hoặc mật khẩu không chính xác.";
            return View();
        }

        // Đăng nhập thành công, lưu thông tin nhân viên vào session
        HttpContext.Session.SetInt32("MaNhanVien", nhanVien.MaNhanVien);
        HttpContext.Session.SetString("HoTen", nhanVien.HoTen);
        ViewData["UserName"] = nhanVien.HoTen;
        // hoặc
        ViewBag.UserName = nhanVien.HoTen;
        return RedirectToAction("Index", "Home"); // Điều hướng đến trang chủ sau khi đăng nhập thành công
    }

  
}
