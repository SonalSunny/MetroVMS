using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetroVMS.Pages.BookMeetingRoom
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet_IndexPartial()
        {
            return Partial("_IndexPartial");
        }

      
    }
}
