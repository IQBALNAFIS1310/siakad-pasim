using Microsoft.AspNetCore.Mvc;

namespace siakad_pasim.Controllers
{
    public class LoginPagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
