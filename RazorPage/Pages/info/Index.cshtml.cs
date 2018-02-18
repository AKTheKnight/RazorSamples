using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.Pages.info
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Index page of the info folder";
        }
    }
}