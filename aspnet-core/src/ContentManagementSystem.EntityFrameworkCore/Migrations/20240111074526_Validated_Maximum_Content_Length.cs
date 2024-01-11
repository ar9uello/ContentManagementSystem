using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContentManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class Validated_Maximum_Content_Length : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "HtmlContent",
                table: "Contents",
                type: "VARBINARY(500)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "VARBINARY(MAX)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "HtmlContent",
                table: "Contents",
                type: "VARBINARY(MAX)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "VARBINARY(500)");
        }
    }
}
