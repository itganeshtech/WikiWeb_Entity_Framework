using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeGenreTableandColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "tb_Genre");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "tb_Genre",
                newName: "col_GenreName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Genre",
                table: "tb_Genre",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Genre",
                table: "tb_Genre");

            migrationBuilder.RenameTable(
                name: "tb_Genre",
                newName: "Genres");

            migrationBuilder.RenameColumn(
                name: "col_GenreName",
                table: "Genres",
                newName: "GenreName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreId");
        }
    }
}
