using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestAppWeb.Pages
{
    public class ChatModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }

        public void OnGet()
        {
            UserName = @User.Identity.Name;
        }
    }
}
