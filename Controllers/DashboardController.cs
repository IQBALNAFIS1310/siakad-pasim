using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using siakad_pasim.Models;

namespace siakad_pasim.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var totalMahasiswa = _context.Mahasiswas.Count();
            ViewBag.TotalMahasiswa = totalMahasiswa;

            return View();
        }
    }
}
