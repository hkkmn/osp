using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace osp.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameSurename",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameSurename",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
