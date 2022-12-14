using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_EF_Core.Domain.Migrations
{
    public partial class applyFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategorieContact",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ContactsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieContact", x => new { x.CategoriesId, x.ContactsId });
                    table.ForeignKey(
                        name: "FK_CategorieContact_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategorieContact_Contacts_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UtilisateurId",
                table: "Categories",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_CategorieContact_ContactsId",
                table: "CategorieContact",
                column: "ContactsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Utilisateurs_UtilisateurId",
                table: "Categories",
                column: "UtilisateurId",
                principalTable: "Utilisateurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Utilisateurs_UtilisateurId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "CategorieContact");

            migrationBuilder.DropIndex(
                name: "IX_Categories_UtilisateurId",
                table: "Categories");
        }
    }
}
