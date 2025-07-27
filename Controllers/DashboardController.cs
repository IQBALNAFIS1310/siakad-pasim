using Microsoft.AspNetCore.Mvc;

namespace siakad_pasim.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
