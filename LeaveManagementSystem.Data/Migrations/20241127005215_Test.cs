using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe6e6408-cc97-419b-9060-4d483149b4a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4863377-d25a-4a6a-93f5-05f9a5556a68", "AQAAAAIAAYagAAAAEO088u8AZJVp+FUxzLwNBhdesuwAoIohRJuSuspukA7/bfvRCwW0vv0Ge8Pu5kqa7Q==", "3f345eea-3e32-489d-95af-da911b847c84" });

            migrationBuilder.UpdateData(
                table: "LeaveRequestStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Canceled");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe6e6408-cc97-419b-9060-4d483149b4a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d28aa478-ab2f-48d3-a441-b84036256188", "AQAAAAIAAYagAAAAECCGoilFPtLMZ80VdpQnp7S1nqjk5DSKEmF1777MopFzW7wlIlDXavPLZtUzJ2qUjQ==", "c34aab0d-7bc2-414f-9ffd-fc8516b49771" });

            migrationBuilder.UpdateData(
                table: "LeaveRequestStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Cancled");
        }
    }
}
