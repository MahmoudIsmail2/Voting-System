using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domains.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "TbUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAge = table.Column<int>(type: "int", nullable: false),
                    UserJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserExperience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbUsers", x => x.UserId);
                });

           
           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbImgs");

            migrationBuilder.DropTable(
                name: "TbUsers");

            migrationBuilder.DropTable(
                name: "TbVoteOptions");

            migrationBuilder.DropTable(
                name: "TbClubs");

            migrationBuilder.DropTable(
                name: "TbCochs");

            migrationBuilder.DropTable(
                name: "TbGks");

            migrationBuilder.DropTable(
                name: "TbPlayers");
        }
    }
}
