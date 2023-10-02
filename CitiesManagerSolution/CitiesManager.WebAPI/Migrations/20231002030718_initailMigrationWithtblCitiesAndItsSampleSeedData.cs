using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitiesManager.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class initailMigrationWithtblCitiesAndItsSampleSeedData : Migration
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
                    cityCode = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    cityName = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    latitude = table.Column<decimal>(type: "decimal(18,15)", nullable: true),
                    longitude = table.Column<decimal>(type: "decimal(18,15)", nullable: true),
                    regAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 2, 6, 7, 18, 274, DateTimeKind.Local).AddTicks(2866)),
                    status = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCities", x => x.cityId);
                });

            migrationBuilder.InsertData(
                schema: "CitiesManagerDb",
                table: "tblCities",
                columns: new[] { "cityId", "cityCode", "cityName", "latitude", "longitude", "status" },
                values: new object[] { new Guid("a32054f2-54c9-4a95-91e6-1b24558573a6"), "MGQ", "Mogadishu", 2.05368398776368m, 45.31820111676328m, "active" });
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
