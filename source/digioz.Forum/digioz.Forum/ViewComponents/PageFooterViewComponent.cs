using Microsoft.AspNetCore.Mvc;

namespace digioz.Forum.ViewComponents
{
    public class PageFooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
