using Microsoft.AspNetCore.Mvc;

namespace digioz.Forum.ViewComponents
{
    public class LoginBoxViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
