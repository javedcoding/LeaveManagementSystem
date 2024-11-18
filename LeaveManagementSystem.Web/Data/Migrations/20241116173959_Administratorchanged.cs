using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class Administratorchanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57244434-5457-4c86-a6ba-079b397da049",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe6e6408-cc97-419b-9060-4d483149b4a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d310fd6-42a0-4d40-a0ee-8c8b3c99f381", "AQAAAAIAAYagAAAAEGpmEg/f57oGigNrw+rMySoWGiHIBQsasvbF0xNi5Ycqho2arp2xBRpAGs6YieKqOQ==", "6e78bce9-b3c3-48d7-a000-7c9abd1baaca" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57244434-5457-4c86-a6ba-079b397da049",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Adminstrator", "ADMINSTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe6e6408-cc97-419b-9060-4d483149b4a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2172973-c5a9-4d5d-850b-1d15ea08659b", "AQAAAAIAAYagAAAAEDR7lI1XGromJ6UKYQ2Rm4ZwC1+s7kSuhAF3xcvBRe0wbAHAa9RjRsSiro+To6WJqQ==", "6159e1c2-8609-43bb-be27-a1dcc5ec4167" });
        }
    }
}
