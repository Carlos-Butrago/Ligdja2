
using Microsoft.AspNetCore.Mvc;

namespace Ligdja_web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    
        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }


        public IActionResult promocoes()
        {
            return View();
        }
    }
}
