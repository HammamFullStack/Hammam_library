using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hammam_library.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Hammam" },
                    { 2, "Davinci" },
                    { 3, "John" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Name", "Password", "Username" },
                values: new object[] { 1, "Administrator", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "Edition", "Title" },
                values: new object[] { 1, 1, "First", "Web Programming" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "Edition", "Title" },
                values: new object[] { 2, 2, "Second", "Mona lisa" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "AuthorID", "Edition", "Title" },
                values: new object[] { 3, 3, "Third", "Doe" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                table: "Books",
                column: "AuthorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
