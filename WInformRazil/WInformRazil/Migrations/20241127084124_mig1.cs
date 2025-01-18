using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WInformRazil.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Borrowers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakenQuantity = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BorrowerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Borrowers_BorrowerId",
                        column: x => x.BorrowerId,
                        principalTable: "Borrowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "Name", "PageCount", "Quantity" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "The Great Gatsby", 180, 5 },
                    { 2, "George Orwell", "1984", 328, 3 },
                    { 3, "Harper Lee", "To Kill a Mockingbird", 281, 4 },
                    { 4, "Jane Austen", "Pride and Prejudice", 279, 6 },
                    { 5, "Herman Melville", "Moby-Dick", 635, 2 },
                    { 6, "Leo Tolstoy", "War and Peace", 1225, 1 },
                    { 7, "Homer", "The Odyssey", 541, 4 },
                    { 8, "James Joyce", "Ulysses", 730, 3 },
                    { 9, "J.D. Salinger", "The Catcher in the Rye", 277, 5 },
                    { 10, "Aldous Huxley", "Brave New World", 268, 7 }
                });

            migrationBuilder.InsertData(
                table: "Borrowers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Default Borrower" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "BookId", "BorrowerId", "TakenQuantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 0 },
                    { 2, 2, 1, 0 },
                    { 3, 3, 1, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BookId",
                table: "Transactions",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_BorrowerId",
                table: "Transactions",
                column: "BorrowerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Borrowers");
        }
    }
}
