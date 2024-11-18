using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveAllocationType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe6e6408-cc97-419b-9060-4d483149b4a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd147c4-8d35-4098-a14b-a8dd4db73936", "AQAAAAIAAYagAAAAEEdZQcgw2waETLiMSn8WENhm/1EWCy+cwinP6wh/ekWyZmxMwM3AxgxpKTk0bwUUFA==", "cb7171f0-aa9d-4233-b1ec-6614f4f7258a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe6e6408-cc97-419b-9060-4d483149b4a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a8e306b-449a-42c5-b102-f417859d4bc8", "AQAAAAIAAYagAAAAEBXx+qRVpQFu531pFf+SbxdKLQImYr8AhjdEf8u1vsCaS0LRP3/mBPZQiVXpn+RhjA==", "180d30a5-9e24-434f-8b33-ebef824c7b13" });
        }
    }
}
