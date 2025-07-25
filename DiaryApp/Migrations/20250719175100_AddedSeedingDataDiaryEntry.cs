using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DairyApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { 1, "Went Hiking With Jao", new DateTime(2025, 7, 19, 23, 20, 59, 31, DateTimeKind.Local).AddTicks(9004), "Went Hiking" },
                    { 2, "Went Shopping With Jao", new DateTime(2025, 7, 19, 23, 20, 59, 31, DateTimeKind.Local).AddTicks(9007), "Went Shopping" },
                    { 3, "Went Driving With Jao", new DateTime(2025, 7, 19, 23, 20, 59, 31, DateTimeKind.Local).AddTicks(9009), "Went Drivind" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
