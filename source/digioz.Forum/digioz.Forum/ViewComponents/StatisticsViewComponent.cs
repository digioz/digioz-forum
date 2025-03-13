using Microsoft.AspNetCore.Mvc;

namespace digioz.Forum.ViewComponents
{
    public class StatisticsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
