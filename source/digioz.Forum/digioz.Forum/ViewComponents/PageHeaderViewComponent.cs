using Microsoft.AspNetCore.Mvc;

namespace digioz.Forum.ViewComponents
{
    public class PageHeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
