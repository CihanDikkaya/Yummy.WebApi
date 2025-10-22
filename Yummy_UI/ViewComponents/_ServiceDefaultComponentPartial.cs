using Microsoft.AspNetCore.Mvc;

namespace Yummy_UI.ViewComponents
{
    public class _ServiceDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
