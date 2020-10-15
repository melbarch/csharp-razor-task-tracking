
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class CreateTaskModel : PageModel
    {
        [BindProperty]
        public Task NewTask { get; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("Index");
        }
    }
}