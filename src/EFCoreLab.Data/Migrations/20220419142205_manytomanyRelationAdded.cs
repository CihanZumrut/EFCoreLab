using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreLab.Data.Migrations
{
    public partial class manytomanyRelationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_courses_CourseId",
                schema: "dbo",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_CourseId",
                schema: "dbo",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CourseId",
                schema: "dbo",
                table: "students");

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                schema: "dbo",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_courses_CoursesId",
                        column: x => x.CoursesId,
                        principalSchema: "dbo",
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_students_StudentsId",
                        column: x => x.StudentsId,
                        principalSchema: "dbo",
                        principalTable: "students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                schema: "dbo",
                table: "CourseStudent",
                column: "StudentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent",
                schema: "dbo");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                schema: "dbo",
                table: "students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_CourseId",
                schema: "dbo",
                table: "students",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_courses_CourseId",
                schema: "dbo",
                table: "students",
                column: "CourseId",
                principalSchema: "dbo",
                principalTable: "courses",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
