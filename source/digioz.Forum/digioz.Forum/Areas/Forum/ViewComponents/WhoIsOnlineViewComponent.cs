using Microsoft.AspNetCore.Mvc;

namespace digioz.Forum.Areas.Forum.ViewComponents
{
    public class WhoIsOnlineViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // Explicitly use the view located under the Forum area
            return View("~/Areas/Forum/Pages/Shared/Components/WhoIsOnline/default.cshtml");
        }
    }
}
