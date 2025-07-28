using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace siakad_pasim.Migrations
{
    /// <inheritdoc />
    public partial class edittypedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mahasiswas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgramStudi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TanggalMasuk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusMahasiswa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JenisPendaftaran = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BiayaMasuk = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JenisKelamin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempatLahir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TanggalLahir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusSync = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahasiswas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mahasiswas");
        }
    }
}
