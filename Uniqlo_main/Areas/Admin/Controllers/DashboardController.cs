using Microsoft.AspNetCore.Mvc;

namespace Uniqlo_main.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
