using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcVhsLibrary.Data.Migrations
{
    /// <inheritdoc />
    public partial class VhsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VHSTape",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VHSTape", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VHSTape");
        }
    }
}
