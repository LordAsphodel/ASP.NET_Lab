using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieModel",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 64, nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(maxLength: 64, nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VechicleModel",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Company = table.Column<string>(maxLength: 64, nullable: false),
                    ModelType = table.Column<string>(maxLength: 64, nullable: false),
                    ReleaseDate = table.Column<int>(nullable: false),
                    RegistrationNumber = table.Column<string>(maxLength: 6, nullable: false),
                    RegistrationCity = table.Column<int>(nullable: false),
                    Distance = table.Column<double>(nullable: false),
                    WasRepaired = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VechicleModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieModel");

            migrationBuilder.DropTable(
                name: "VechicleModel");
        }
    }
}
