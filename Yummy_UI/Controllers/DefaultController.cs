using Microsoft.AspNetCore.Mvc;

namespace Yummy_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
