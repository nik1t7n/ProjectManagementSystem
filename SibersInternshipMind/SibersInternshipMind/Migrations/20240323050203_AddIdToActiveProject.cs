using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SibersInternshipMind.Migrations
{
    /// <inheritdoc />
    public partial class AddIdToActiveProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ActiveProjects",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActiveProjects",
                table: "ActiveProjects",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ActiveProjects",
                table: "ActiveProjects");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ActiveProjects");
        }
    }
}
