using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace digioz.Forum.Areas.Forum.Pages.Mcp
{
    [Authorize(Roles = "Moderator,Administrator")]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
