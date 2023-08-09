using Microsoft.AspNetCore.Mvc;

namespace QuanLyKhachSan.Controllers
{
    public class CusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
