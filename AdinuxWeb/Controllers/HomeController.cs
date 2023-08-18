using Microsoft.AspNetCore.Mvc;

namespace AdinuxWeb.Controllers
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
            return View();
        }
        public IActionResult Adilyze()
        {
            return View();
        }
        public IActionResult Adicamp()
        {
            return View();
        }
        public IActionResult Adishop()
        {
            return View();
        }
        public IActionResult AdiShow()
        {
            return View();
        }
        public IActionResult Adimag()
        {
            return View();
        }
        public IActionResult Adiroom()
        {
            return View();
        }
        public IActionResult Adibox()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}