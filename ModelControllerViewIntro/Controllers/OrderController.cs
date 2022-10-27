using Microsoft.AspNetCore.Mvc;

namespace ModelControllerViewIntro.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

        public IActionResult NyOrder()
        {
            return View();
        }

        public IActionResult RedigeraOrder()
        {
            return View();
        }


    }
}
