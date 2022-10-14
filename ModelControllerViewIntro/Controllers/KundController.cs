using Microsoft.AspNetCore.Mvc;
using ModelControllerViewIntro.Models;
using System.Collections.Generic;

namespace ModelControllerViewIntro.Controllers
{
    public class KundController : Controller
    {
        

        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult Detaljer()
        {
            // någon process som ta fram rätt kund.
            Kund k = new Kund()
            {
                realname = "Jon Köpingsson",
                username = "kopjo"
            };
            return View(k);
        }

       

        public IActionResult AllaKunder()
        {
            List<Kund> allaK = new List<Kund>();
            Kund k = new Kund()
            {
                realname = "Jon Köpingsson",
                username = "kopjo"
            };
             
            allaK.Add(k);

            k = new Kund()
            {
                realname = "Hans Habo",
                username = "habha"
            };
            allaK.Add(k);

            return View(allaK);
        }
    }
}
