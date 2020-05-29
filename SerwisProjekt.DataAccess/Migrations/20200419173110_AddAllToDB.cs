using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SerwisProjekt.DataAccess.Migrations
{
    public partial class AddAllToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klient",
                columns: table => new
                {
                    KlientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImieNazwisko = table.Column<string>(maxLength: 20, nullable: false),
                    NumerTel = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Haslo = table.Column<byte[]>(maxLength: 24, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klient", x => x.KlientId);
                });

            migrationBuilder.CreateTable(
                name: "Pracownik",
                columns: table => new
                {
                    PracownikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImieNazwiskoPracownika = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownik", x => x.PracownikId);
                });

            migrationBuilder.CreateTable(
                name: "Serwisant",
                columns: table => new
                {
                    SerwisantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImieNazwisko = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serwisant", x => x.SerwisantId);
                });

            migrationBuilder.CreateTable(
                name: "StatusNaprawy",
                columns: table => new
                {
                    StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaStatusu = table.Column<string>(maxLength: 20, nullable: false),
                    OpisStatusu = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusNaprawy", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "StatusZam",
                columns: table => new
                {
                    ZamStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaStatusuZam = table.Column<string>(nullable: false),
                    OpisStatusuZam = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusZam", x => x.ZamStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Naprawa",
                columns: table => new
                {
                    NaprawaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(nullable: false),
                    Kwota = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    SerwisantId = table.Column<int>(nullable: false),
                    KlientId = table.Column<int>(nullable: false),
                    StatusNaprawyStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Naprawa", x => x.NaprawaId);
                    table.ForeignKey(
                        name: "FK_Naprawa_Klient_KlientId",
                        column: x => x.KlientId,
                        principalTable: "Klient",
                        principalColumn: "KlientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Naprawa_Serwisant_SerwisantId",
                        column: x => x.SerwisantId,
                        principalTable: "Serwisant",
                        principalColumn: "SerwisantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Naprawa_StatusNaprawy_StatusNaprawyStatusId",
                        column: x => x.StatusNaprawyStatusId,
                        principalTable: "StatusNaprawy",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienie",
                columns: table => new
                {
                    ZamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KwotaZam = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NaprawaId = table.Column<int>(nullable: false),
                    ZamStatusId = table.Column<int>(nullable: false),
                    PracownikId = table.Column<int>(nullable: false),
                    StatusZamZamStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienie", x => x.ZamId);
                    table.ForeignKey(
                        name: "FK_Zamowienie_Naprawa_NaprawaId",
                        column: x => x.NaprawaId,
                        principalTable: "Naprawa",
                        principalColumn: "NaprawaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zamowienie_Pracownik_PracownikId",
                        column: x => x.PracownikId,
                        principalTable: "Pracownik",
                        principalColumn: "PracownikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zamowienie_StatusZam_StatusZamZamStatusId",
                        column: x => x.StatusZamZamStatusId,
                        principalTable: "StatusZam",
                        principalColumn: "ZamStatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Naprawa_KlientId",
                table: "Naprawa",
                column: "KlientId");

            migrationBuilder.CreateIndex(
                name: "IX_Naprawa_SerwisantId",
                table: "Naprawa",
                column: "SerwisantId");

            migrationBuilder.CreateIndex(
                name: "IX_Naprawa_StatusNaprawyStatusId",
                table: "Naprawa",
                column: "StatusNaprawyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienie_NaprawaId",
                table: "Zamowienie",
                column: "NaprawaId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienie_PracownikId",
                table: "Zamowienie",
                column: "PracownikId");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienie_StatusZamZamStatusId",
                table: "Zamowienie",
                column: "StatusZamZamStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zamowienie");

            migrationBuilder.DropTable(
                name: "Naprawa");

            migrationBuilder.DropTable(
                name: "Pracownik");

            migrationBuilder.DropTable(
                name: "StatusZam");

            migrationBuilder.DropTable(
                name: "Klient");

            migrationBuilder.DropTable(
                name: "Serwisant");

            migrationBuilder.DropTable(
                name: "StatusNaprawy");
        }
    }
}
