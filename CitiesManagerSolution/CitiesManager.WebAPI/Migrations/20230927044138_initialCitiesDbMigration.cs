using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitiesManager.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialCitiesDbMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CitiesManagerDb");

            migrationBuilder.CreateTable(
                name: "tblCities",
                schema: "CitiesManagerDb",
                columns: table => new
                {
                    cityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cityCode = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    cityName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    latitude = table.Column<decimal>(type: "decimal(18,15)", nullable: false),
                    longitude = table.Column<decimal>(type: "decimal(18,15)", nullable: false),
                    regAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 9, 27, 7, 41, 38, 355, DateTimeKind.Local).AddTicks(6228))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCities", x => x.cityId);
                });

            migrationBuilder.InsertData(
                schema: "CitiesManagerDb",
                table: "tblCities",
                columns: new[] { "cityId", "cityCode", "cityName", "latitude", "longitude" },
                values: new object[] { new Guid("a32054f2-54c9-4a95-91e6-1b24558573a6"), "MGQ", "Mogadishu", 2.05368398776368m, 45.31820111676328m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCities",
                schema: "CitiesManagerDb");
        }
    }
}
