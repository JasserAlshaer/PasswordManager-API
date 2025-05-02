using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PasswordManager_API.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LookupItems",
                columns: new[] { "Id", "CreatedBy", "CreationDate", "IsActive", "LookupTypeId", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8642), true, 2, "Client", null, null },
                    { 2, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8643), true, 2, "Admin", null, null },
                    { 10, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8640), true, 1, "Jordanin", null, null },
                    { 100, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8644), true, 3, "Phone", null, null },
                    { 101, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8644), true, 3, "Name", null, null },
                    { 102, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8645), true, 3, "Email", null, null },
                    { 103, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8646), true, 3, "UserName", null, null },
                    { 104, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8646), true, 3, "National ID", null, null },
                    { 200, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8647), true, 4, "Trainer", null, null },
                    { 201, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8648), true, 4, "Trainere", null, null },
                    { 300, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8649), true, 5, "Personal", null, null },
                    { 301, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8649), true, 5, "Banking", null, null },
                    { 302, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8650), true, 5, "Social Media", null, null },
                    { 303, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8651), true, 5, "Other", null, null }
                });

            migrationBuilder.InsertData(
                table: "LookupTypes",
                columns: new[] { "Id", "CreatedBy", "CreationDate", "IsActive", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8493), true, "Nationality", null, null },
                    { 2, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8503), true, "Role", null, null },
                    { 3, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8504), true, "UsernameType", null, null },
                    { 4, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8504), true, "Specialization", null, null },
                    { 5, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8505), true, "Category", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreationDate", "Email", "IsActive", "IsLoggedIn", "IsVerfied", "LastLoginTime", "OTPCode", "OTPExipry", "Password", "RoleId", "UpdatedBy", "UpdatedDate", "UserName" },
                values: new object[] { 1, "System", new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8672), "b846bad23206df937f768e06362affb42a22ea8658c2403642b2a0049e81709297ad89e2a7946c48be8462dcd622f169", true, null, true, null, null, null, "d62915f355cf243d2d90f2d7c506af00baee5d3e8d3870d656a354fcd0a25c87c9b648a6f2c59ece1bfb002d5d2c0567", 2, null, null, "fc8c0c79545bb5e9afe969574c81eeabe7702cad289584b0b19dfedfbeb338a626b855a7ddb54a9ff0a9b73c76cb3fdf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
