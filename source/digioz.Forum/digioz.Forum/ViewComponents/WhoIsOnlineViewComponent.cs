using Microsoft.AspNetCore.Mvc;

namespace digioz.Forum.ViewComponents
{
    public class WhoIsOnlineViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
