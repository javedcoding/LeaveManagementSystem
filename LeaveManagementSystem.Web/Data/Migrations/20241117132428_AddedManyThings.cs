using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedManyThings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe6e6408-cc97-419b-9060-4d483149b4a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a8e306b-449a-42c5-b102-f417859d4bc8", "AQAAAAIAAYagAAAAEBXx+qRVpQFu531pFf+SbxdKLQImYr8AhjdEf8u1vsCaS0LRP3/mBPZQiVXpn+RhjA==", "180d30a5-9e24-434f-8b33-ebef824c7b13" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe6e6408-cc97-419b-9060-4d483149b4a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d310fd6-42a0-4d40-a0ee-8c8b3c99f381", "AQAAAAIAAYagAAAAEGpmEg/f57oGigNrw+rMySoWGiHIBQsasvbF0xNi5Ycqho2arp2xBRpAGs6YieKqOQ==", "6e78bce9-b3c3-48d7-a000-7c9abd1baaca" });
        }
    }
}
