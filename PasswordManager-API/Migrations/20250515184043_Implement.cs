using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordManager_API.Migrations
{
    /// <inheritdoc />
    public partial class Implement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3242), "Jordanian" });

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.InsertData(
                table: "LookupItems",
                columns: new[] { "Id", "CreatedBy", "CreationDate", "IsActive", "LookupTypeId", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 3, "System", new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3245), true, 2, "Driver", null, null });

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3156));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 15, 21, 40, 43, 433, DateTimeKind.Local).AddTicks(3273));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationDate", "Name" },
                values: new object[] { new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8861), "Jordanin" });

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8894));
        }
    }
}
