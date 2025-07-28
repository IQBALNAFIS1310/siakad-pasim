using Microsoft.EntityFrameworkCore;
using siakad_pasim.Models.Dbs;

namespace siakad_pasim.Models
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Mahasiswa> Mahasiswas { get; set; }
    }
}
