using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataforDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4528a864-e1dc-4ca1-9137-89eaca2a2f5b"), "Medium" },
                    { new Guid("49bf7e61-c270-4696-bc73-c99e65cdb2ab"), "Hard" },
                    { new Guid("f70ccf97-acc0-4e11-b00a-2f3cba06ab75"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("2e341708-e99a-4e0b-b7e3-361858456129"), "STL", "Southland", "null" },
                    { new Guid("2f6a9dcc-3521-4051-8ede-3287f9f4329c"), "BOP", "Bay Of Plenty", "null" },
                    { new Guid("462ad8fc-16d1-4012-9a6f-a35ccb1c900b"), "AKL", "Auckland", "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("5df0ecf3-4591-4586-986e-1f36a5951f1e"), "WGN", "Wellington", "a_wellington_image.png" },
                    { new Guid("a0fb25ed-c44b-4484-93ac-d876f642cfce"), "NSN", "Nelson", "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { new Guid("d4095cb5-5d90-4f0f-9daa-ae70f3d7bab4"), "NTL", "Northland", "null" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("4528a864-e1dc-4ca1-9137-89eaca2a2f5b"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("49bf7e61-c270-4696-bc73-c99e65cdb2ab"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("f70ccf97-acc0-4e11-b00a-2f3cba06ab75"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2e341708-e99a-4e0b-b7e3-361858456129"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2f6a9dcc-3521-4051-8ede-3287f9f4329c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("462ad8fc-16d1-4012-9a6f-a35ccb1c900b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5df0ecf3-4591-4586-986e-1f36a5951f1e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a0fb25ed-c44b-4484-93ac-d876f642cfce"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d4095cb5-5d90-4f0f-9daa-ae70f3d7bab4"));
        }
    }
}
