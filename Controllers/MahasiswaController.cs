using Microsoft.AspNetCore.Mvc;
using siakad_pasim.Models.Dbs;
using siakad_pasim.Services;

namespace siakad_pasim.Controllers
{
    public class MahasiswaController : Controller
    {
        private readonly MahasiswaService _service;

        public MahasiswaController(MahasiswaService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }

        public IActionResult Details(int id)
        {
            var mahasiswa = _service.GetById(id);
            if (mahasiswa == null) return NotFound();
            return View(mahasiswa);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Mahasiswa mahasiswa)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _service.Create(mahasiswa);
                    TempData["Success"] = "Data mahasiswa berhasil ditambahkan.";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {

                    // Pesan error ke user
                    TempData["Error"] = $"Terjadi kesalahan saat menyimpan data. \"Error saat menyimpan data mahasiswa: {ex.Message}\"";
                }
            }
            else
            {
                TempData["Error"] = "Validasi gagal. Periksa kembali data yang diinput.";
            }

            // Jika gagal, kembali ke view dengan data lama
            return View(mahasiswa);
        }

        public IActionResult Edit(int id)
        {
            var mahasiswa = _service.GetById(id);
            if (mahasiswa == null) return NotFound();
            return View(mahasiswa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Mahasiswa mahasiswa)
        {
            if (id != mahasiswa.Id) return BadRequest();

            if (ModelState.IsValid)
            {
                _service.Update(mahasiswa);
                TempData["Success"] = "Data mahasiswa berhasil diperbarui.";
                return RedirectToAction(nameof(Index));
            }

            TempData["Error"] = "Gagal memperbarui data.";
            return View(mahasiswa);
        }

        public IActionResult Delete(int id)
        {
            var mahasiswa = _service.GetById(id);
            if (mahasiswa == null) return NotFound();
            return View(mahasiswa);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var mahasiswa = _service.GetById(id);
            if (mahasiswa == null)
            {
                TempData["Error"] = "Data mahasiswa tidak ditemukan.";
                return RedirectToAction(nameof(Index));
            }

            try
            {
                mahasiswa.StatusMahasiswa = "NONAKTIF";
                _service.Update(mahasiswa); // Update status mahasiswa jadi NONAKTIF

                TempData["Success"] = "Status mahasiswa berhasil diubah menjadi NONAKTIF.";
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Gagal mengubah status: {ex.Message}";
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
