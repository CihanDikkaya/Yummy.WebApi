using Microsoft.AspNetCore.Mvc;

namespace Yummy_UI.ViewComponents
{
    public class _FeatureDefaultComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
