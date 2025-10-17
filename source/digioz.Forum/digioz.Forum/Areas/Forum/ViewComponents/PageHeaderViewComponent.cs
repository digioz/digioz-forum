using Microsoft.AspNetCore.Mvc;

namespace digioz.Forum.Areas.Forum.ViewComponents
{
    public class PageHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // Explicitly use the view located under the Forum area
            return View("~/Areas/Forum/Pages/Shared/Components/PageHeader/default.cshtml");
        }
    }
}
