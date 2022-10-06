using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ED_Razor_Test_01.Pages
{
    public class CalculatorModel : PageModel
    {

        [BindProperty, Required]
        public double tal1 { get;  }
        [BindProperty, Required]
        public double tal2 { get; }

        public  string TheMethod = "not definied"; 
        public void OnGet()
        {
            TheMethod = "GET";
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // do something
                return RedirectToPage("Calculator");
            }
            else
            {
                return Page();
            }
        }

    }
}
