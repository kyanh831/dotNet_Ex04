using Microsoft.AspNetCore.Mvc;

namespace Ex04.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class DashboardController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
