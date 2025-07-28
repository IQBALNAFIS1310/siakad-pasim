using siakad_pasim.Models;
using siakad_pasim.Models.Dbs;

namespace siakad_pasim.Services
{
    public class MahasiswaService
    {
        private readonly ApplicationDbContext _context;

        public MahasiswaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Mahasiswa> GetAll()
        {
            return _context.Mahasiswas.OrderBy(m => m.Id).ToList();
        }

        public Mahasiswa? GetById(int id)
        {
            return _context.Mahasiswas.FirstOrDefault(m => m.Id == id);
        }

        public void Create(Mahasiswa mhs)
        {
            _context.Mahasiswas.Add(mhs);
            _context.SaveChanges();
        }

        public void Update(Mahasiswa mhs)
        {
            _context.Mahasiswas.Update(mhs);
            _context.SaveChanges();
        }
        //tidak digunakan karena soft delete
        //public void Delete(int id)
        //{
        //    var mhs = _context.Mahasiswas.FirstOrDefault(m => m.Id == id);
        //    if (mhs != null)
        //    {
        //        _context.Mahasiswas.Remove(mhs);
        //        _context.SaveChanges();
        //    }
        //}
    }
}
