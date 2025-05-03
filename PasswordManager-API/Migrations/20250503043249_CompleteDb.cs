using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PasswordManager_API.Migrations
{
    /// <inheritdoc />
    public partial class CompleteDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsernameTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: true),
                    UserNameNonce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserNameTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordNonce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordTag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Key = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                });

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
                column: "CreationDate",
                value: new DateTime(2025, 5, 3, 7, 32, 48, 919, DateTimeKind.Local).AddTicks(8861));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "LookupItems",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "LookupTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 5, 2, 23, 10, 25, 738, DateTimeKind.Local).AddTicks(8672));
        }
    }
}
