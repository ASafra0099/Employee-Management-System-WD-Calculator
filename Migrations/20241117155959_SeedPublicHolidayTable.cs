using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagement_system.Migrations
{
    /// <inheritdoc />
    public partial class SeedPublicHolidayTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PublicHolidays",
                columns: new[] { "Id", "Date", "Description" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Year's Day" },
                    { 2, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Labour Day" },
                    { 3, new DateTime(2024, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esala Full Moon (Poya Day)" },
                    { 4, new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nikini Full Moon (Poya Day)" },
                    { 5, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Binara Full Moon (Poya Day)" },
                    { 6, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duruthu Full Moon (Poya Day)" },
                    { 7, new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christmas Day" },
                    { 8, new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boxing Day" },
                    { 9, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mawlid al-Nabi (Prophet Muhammad's Birthday)" },
                    { 10, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eid ul-Fitr" },
                    { 11, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eid ul-Azha" },
                    { 12, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duruthu Poya" },
                    { 13, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Navam Poya" },
                    { 14, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madin Poya" },
                    { 15, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bak Full Moon Poya" },
                    { 16, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vesak Poya" },
                    { 17, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Poson Poya" },
                    { 18, new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Esala Poya" },
                    { 19, new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nikini Poya" },
                    { 20, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Binara Poya" },
                    { 21, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Duruthu Poya" },
                    { 22, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ill Full Moon Poya" },
                    { 23, new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unduvap Poya" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PublicHolidays",
                keyColumn: "Id",
                keyValue: 23);
        }
    }
}
