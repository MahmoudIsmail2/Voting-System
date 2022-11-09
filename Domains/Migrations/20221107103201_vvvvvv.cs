using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domains.Migrations
{
    /// <inheritdoc />
    public partial class vvvvvv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "userid",
                table: "TbVoteOptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "voteid",
                table: "TbVoteOptions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "voteid",
                table: "TbVoteOptions");

            migrationBuilder.AlterColumn<string>(
                name: "userid",
                table: "TbVoteOptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
