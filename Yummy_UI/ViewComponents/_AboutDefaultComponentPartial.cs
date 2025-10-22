using Microsoft.AspNetCore.Mvc;

namespace Yummy_UI.ViewComponents
{
    public class _AboutDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
