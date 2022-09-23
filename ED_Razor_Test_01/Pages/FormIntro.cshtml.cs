using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ED_Razor_Test_01.Pages
{
    public class FormIntroModel : PageModel
    {
        public void OnGet()
        {
        }

        [ActionName("Trigger")]
        public IActionResult Trigger(int a)
        {
            return NotFound(a);
        }
    }
}
