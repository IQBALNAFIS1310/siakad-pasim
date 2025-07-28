using System.ComponentModel.DataAnnotations;

namespace siakad_pasim.Models.Dbs
{
    public class Mahasiswa
    {
        [Key]
        public int Id { get; set; }
        public string NIM { get; set; }
        public string NIK { get; set; }
        public string Nama { get; set; }
        public string ProgramStudi { get; set; }
        public DateTime TanggalMasuk { get; set; }
        public string StatusMahasiswa { get; set; }
        public string JenisPendaftaran { get; set; }
        public decimal BiayaMasuk { get; set; }
        public string JenisKelamin { get; set; }
        public string TempatTanggalLahir { get; set; }
        public string Agama { get; set; }
        public string Alamat { get; set; }
        public string StatusSync { get; set; }
    }
}
