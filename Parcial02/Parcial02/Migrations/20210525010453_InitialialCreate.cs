using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial02.Migrations
{
    public partial class InitialialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "questions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    question = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "specialties",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    specialitys = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_specialties", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "usernames",
                columns: table => new
                {
                    idCard = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    questionid = table.Column<int>(type: "int", nullable: true),
                    answer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usernames", x => x.idCard);
                    table.ForeignKey(
                        name: "FK_usernames_questions_questionid",
                        column: x => x.questionid,
                        principalTable: "questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioidCard = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    specialityid = table.Column<int>(type: "int", nullable: true),
                    dateAndTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.id);
                    table.ForeignKey(
                        name: "FK_reservations_specialties_specialityid",
                        column: x => x.specialityid,
                        principalTable: "specialties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_reservations_usernames_usuarioidCard",
                        column: x => x.usuarioidCard,
                        principalTable: "usernames",
                        principalColumn: "idCard",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_reservations_specialityid",
                table: "reservations",
                column: "specialityid");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_usuarioidCard",
                table: "reservations",
                column: "usuarioidCard");

            migrationBuilder.CreateIndex(
                name: "IX_usernames_questionid",
                table: "usernames",
                column: "questionid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "specialties");

            migrationBuilder.DropTable(
                name: "usernames");

            migrationBuilder.DropTable(
                name: "questions");
        }
    }
}
