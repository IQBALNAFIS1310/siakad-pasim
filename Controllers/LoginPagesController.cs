using Microsoft.AspNetCore.Mvc;

namespace siakad_pasim.Controllers
{
    public class LoginPagesController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password, string tahunAjaran)
        {
            // Dummy login untuk contoh
            if (username == "admin" && password == "123")
            {
                // Redirect ke dashboard
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.Error = "Login gagal. Username atau password salah.";
                return View();
            }
        }
    }
}
