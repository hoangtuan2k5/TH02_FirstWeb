using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TH02_FirstWeb.Models;

namespace TH02_FirstWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NameList()
        {
            var DanhSachTen = new List<string>
            {
                "Phạm Thị Thu Thủy",
                "Hoàng Nguyễn Du",
                "Hoang Chiều Nguyễn Tuấn",
                "Phạm Hoài An"
            };

            return View(DanhSachTen);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
