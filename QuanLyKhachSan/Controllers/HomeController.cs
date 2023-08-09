using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuanLyKhachSan.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Kiểm tra xem người dùng đã đăng nhập hay chưa
            if (User.Identity.IsAuthenticated)
            {
                string userName = User.Identity.Name;

                // Đưa tên đăng nhập vào ViewData hoặc ViewBag
                ViewData["UserName"] = userName;

                return RedirectToAction("Index", "Home"); // Chuyển hướng về trang chủ
            }

            return View();
        }
        public IActionResult Logout()
        {
            // Xóa thông tin nhân viên trong session khi đăng xuất
            HttpContext.Session.Clear();
            // Xóa thông tin UserName khi đăng xuất
            ViewData["UserName"] = null;
            // hoặc
            ViewBag.UserName = null;

            // Chuyển hướng về trang đăng nhập (AccessController/Login) sau khi đăng xuất
            return RedirectToAction("Login", "Access");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        { 
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
