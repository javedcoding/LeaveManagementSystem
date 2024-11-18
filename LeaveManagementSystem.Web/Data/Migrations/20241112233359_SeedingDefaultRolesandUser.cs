using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesandUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57244434-5457-4c86-a6ba-079b397da049", null, "Administrator", "ADMINISTRATOR" },
                    { "61707094-6be6-439a-b635-a13edefea6ac", null, "Supervisor", "SUPERVISOR" },
                    { "9810262d-f38d-4222-bcdb-2ef3957832b8", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fe6e6408-cc97-419b-9060-4d483149b4a2", 0, "26cdebbb-044b-47ac-9e9e-5ff9b65f58c7", "admin@localdbhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECyN9DbIS7srQxAy6q/LqMzylb7SO1i5IjMKMqruy2nrJfi2fM4lmKuhkT8GpoZCFA==", null, false, "cb07e528-cfea-48f1-9b00-8dc9d1df346c", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "57244434-5457-4c86-a6ba-079b397da049", "fe6e6408-cc97-419b-9060-4d483149b4a2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61707094-6be6-439a-b635-a13edefea6ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9810262d-f38d-4222-bcdb-2ef3957832b8");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57244434-5457-4c86-a6ba-079b397da049", "fe6e6408-cc97-419b-9060-4d483149b4a2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57244434-5457-4c86-a6ba-079b397da049");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe6e6408-cc97-419b-9060-4d483149b4a2");
        }
    }
}
