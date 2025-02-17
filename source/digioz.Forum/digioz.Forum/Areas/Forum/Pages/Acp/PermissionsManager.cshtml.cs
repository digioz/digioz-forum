using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace digioz.Forum.Areas.Forum.Pages.Acp
{
    [Authorize(Roles = "Administrators")]
    public class PermissionsManagerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
