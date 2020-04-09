using Microsoft.EntityFrameworkCore.Migrations;

namespace SerwisProjekt.DataAccess.Migrations
{
    public partial class AddRepairToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Repairs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vin = table.Column<string>(maxLength: 17, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    MechanicId = table.Column<int>(nullable: false),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repairs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Repairs");
        }
    }
}
