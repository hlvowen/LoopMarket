using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OwenVo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateTablesV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Library");

            migrationBuilder.EnsureSchema(
                name: "Merchandise");

            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.EnsureSchema(
                name: "SocialMarketplace");

            migrationBuilder.CreateTable(
                name: "ItemCategory",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemCondition",
                schema: "Merchandise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCondition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PackageFormat",
                schema: "Merchandise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageFormat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemSubCategory",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemSubCategory_ItemCategory_ItemCategoryId",
                        column: x => x.ItemCategoryId,
                        principalSchema: "Catalog",
                        principalTable: "ItemCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                schema: "Merchandise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    ItemConditionId = table.Column<int>(type: "int", nullable: false),
                    PackageFormatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_ItemCondition_ItemConditionId",
                        column: x => x.ItemConditionId,
                        principalSchema: "Merchandise",
                        principalTable: "ItemCondition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_PackageFormat_PackageFormatId",
                        column: x => x.PackageFormatId,
                        principalSchema: "Merchandise",
                        principalTable: "PackageFormat",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LitteraryGenre",
                schema: "Library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemSubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LitteraryGenre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LitteraryGenre_ItemSubCategory_ItemSubCategoryId",
                        column: x => x.ItemSubCategoryId,
                        principalSchema: "Catalog",
                        principalTable: "ItemSubCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                schema: "SocialMarketplace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offer_Item_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "Merchandise",
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                schema: "Library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LitteraryGenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genre_LitteraryGenre_LitteraryGenreId",
                        column: x => x.LitteraryGenreId,
                        principalSchema: "Library",
                        principalTable: "LitteraryGenre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                schema: "Library",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isbn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Genre_GenreId",
                        column: x => x.GenreId,
                        principalSchema: "Library",
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Item_ItemId",
                        column: x => x.ItemId,
                        principalSchema: "Merchandise",
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_GenreId",
                schema: "Library",
                table: "Book",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_ItemId",
                schema: "Library",
                table: "Book",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_LitteraryGenreId",
                schema: "Library",
                table: "Genre",
                column: "LitteraryGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemConditionId",
                schema: "Merchandise",
                table: "Item",
                column: "ItemConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PackageFormatId",
                schema: "Merchandise",
                table: "Item",
                column: "PackageFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSubCategory_ItemCategoryId",
                schema: "Catalog",
                table: "ItemSubCategory",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LitteraryGenre_ItemSubCategoryId",
                schema: "Library",
                table: "LitteraryGenre",
                column: "ItemSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_ItemId",
                schema: "SocialMarketplace",
                table: "Offer",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book",
                schema: "Library");

            migrationBuilder.DropTable(
                name: "Offer",
                schema: "SocialMarketplace");

            migrationBuilder.DropTable(
                name: "Genre",
                schema: "Library");

            migrationBuilder.DropTable(
                name: "Item",
                schema: "Merchandise");

            migrationBuilder.DropTable(
                name: "LitteraryGenre",
                schema: "Library");

            migrationBuilder.DropTable(
                name: "ItemCondition",
                schema: "Merchandise");

            migrationBuilder.DropTable(
                name: "PackageFormat",
                schema: "Merchandise");

            migrationBuilder.DropTable(
                name: "ItemSubCategory",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ItemCategory",
                schema: "Catalog");
        }
    }
}
