using Microsoft.AspNetCore.Mvc;


namespace SindicoWeb.Controllers

{
    public class Dica : Controller
    {

        public IActionResult DicaS()
        {
            return View();
        }

        public IActionResult Receita()
        {
            return View();
        }
     
    }

}