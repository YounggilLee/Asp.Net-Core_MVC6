using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Note.BLL;

namespace Note.MVC6.Controllers
{
    public class HomeController : Controller
    {
        private readonly NoticeBll _noticeBll;

        public HomeController(NoticeBll noticeBll)
        {
            _noticeBll = noticeBll;
        }

        public IActionResult Index()
        {
            var list = _noticeBll.GetNoticeList();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
