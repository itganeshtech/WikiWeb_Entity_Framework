using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wiki_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFluent_OneToOneRelation_Book_BookDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_fluent",
                table: "Book_fluent");

            migrationBuilder.RenameTable(
                name: "Book_fluent",
                newName: "Fluent_Book");

            migrationBuilder.AddColumn<int>(
                name: "Book_Id",
                table: "Fluent_BookDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_Book",
                table: "Fluent_Book",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_BookDetails_Book_Id",
                table: "Fluent_BookDetails",
                column: "Book_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookDetails_Fluent_Book_Book_Id",
                table: "Fluent_BookDetails",
                column: "Book_Id",
                principalTable: "Fluent_Book",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookDetails_Fluent_Book_Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_BookDetails_Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_Book",
                table: "Fluent_Book");

            migrationBuilder.DropColumn(
                name: "Book_Id",
                table: "Fluent_BookDetails");

            migrationBuilder.RenameTable(
                name: "Fluent_Book",
                newName: "Book_fluent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_fluent",
                table: "Book_fluent",
                column: "BookId");
        }
    }
}
