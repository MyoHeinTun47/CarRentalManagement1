using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(684), new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(697), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(701), new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(701), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(1029), new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(1029), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(1032), new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(1032), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(929), new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(929), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(932), new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(933), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(935), new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(935), "Pirus", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(937), new DateTime(2025, 11, 24, 16, 28, 8, 470, DateTimeKind.Local).AddTicks(938), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
