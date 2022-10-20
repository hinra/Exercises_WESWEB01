using Microsoft.AspNetCore.Mvc;
using ModelControllerViewIntro.Models;
using System.Collections.Generic;
using ModelControllerViewIntro.Models; 

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

        public ActionResult NyKund()
        {
            ViewBag.aktuellKund = new Kund() {
                        realname = "Magnus Erkenhed",
                        username = "erkma" };

            ViewBag.Message = "Hello World!"; 

            return View(); 
        }


            [HttpPost]
        public ActionResult SparaNyKund(string username, string realname, string language)
        {           
               // gör något med värden

                return View("Index"); // Leda fel om det inte finns Kund/Index.cshtml        
        }
        
        
        [HttpPost]
        public ActionResult SparaNyKundObjekt(Kund inkommandeK)
        {
            if (ModelState.IsValid)
            {
                Kund nyK = new Kund()
                {
                    username = inkommandeK.username,
                    realname = inkommandeK.realname,
                    language = inkommandeK.language
                };

                //Går något med kunden, tex spara i DB


                return View("Index");
            }
            else
            {
                return View("Index2");
            }
            
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
