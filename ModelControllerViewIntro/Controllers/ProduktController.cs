using Microsoft.AspNetCore.Mvc;

namespace ModelControllerViewIntro.Controllers
{
    public class ProduktController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RedigeraProdukt()
        {
            return View();
        }

        public IActionResult NyProdukt()
        {
            return View();
        }
    }
}
