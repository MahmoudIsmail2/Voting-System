using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domains.Migrations
{
    /// <inheritdoc />
    public partial class addid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "voteid",
                table: "TbVoteOptions",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "TbVoteOptions",
                newName: "voteid");
        }
    }
}
