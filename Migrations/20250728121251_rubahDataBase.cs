using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace siakad_pasim.Migrations
{
    /// <inheritdoc />
    public partial class rubahDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TanggalLahir",
                table: "Mahasiswas");

            migrationBuilder.RenameColumn(
                name: "TempatLahir",
                table: "Mahasiswas",
                newName: "TempatTanggalLahir");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalMasuk",
                table: "Mahasiswas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StatusSync",
                table: "Mahasiswas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<decimal>(
                name: "BiayaMasuk",
                table: "Mahasiswas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TempatTanggalLahir",
                table: "Mahasiswas",
                newName: "TempatLahir");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalMasuk",
                table: "Mahasiswas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "StatusSync",
                table: "Mahasiswas",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BiayaMasuk",
                table: "Mahasiswas",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalLahir",
                table: "Mahasiswas",
                type: "datetime2",
                nullable: true);
        }
    }
}
