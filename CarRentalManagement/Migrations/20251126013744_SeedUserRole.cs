using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "dd3f03eb-1d21-4dee-b058-fd7c7ff231b6", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELUkRGei9CfarhNs59wqFUE8EUbMPFZRFTEGzMSf5rhJBIsKx/7kG8bUM/vCZF5xpg==", null, false, "82a93d42-9fc7-4376-895b-8ae02be06b91", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2261), new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2279), new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2498), new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2501), new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2588), new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2591), new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2593), new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2596), new DateTime(2025, 11, 26, 9, 37, 44, 12, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4106), new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4119), new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4276), new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4278), new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4343), new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4345), new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4346), new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4348), new DateTime(2025, 11, 26, 9, 26, 9, 313, DateTimeKind.Local).AddTicks(4349) });
        }
    }
}
