using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_02.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "dbo",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: false, computedColumnSql: "GETDATE()"),
                    InstructorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                schema: "dbo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                schema: "dbo",
                columns: table => new
                {
                    InstructorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Bouns = table.Column<double>(type: "float", nullable: false),
                    Salary = table.Column<decimal>(type: "Money", nullable: false),
                    Adress = table.Column<string>(type: "varchar", nullable: false),
                    HourRate = table.Column<double>(type: "float", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.InstructorID);
                    table.ForeignKey(
                        name: "FK_Instructor_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalSchema: "dbo",
                        principalTable: "Department",
                        principalColumn: "DepartmentID");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                schema: "dbo",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    LName = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Student_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalSchema: "dbo",
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                schema: "dbo",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Duration = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    TopicID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseID);
                    table.ForeignKey(
                        name: "FK_Course_Topic_TopicID",
                        column: x => x.TopicID,
                        principalSchema: "dbo",
                        principalTable: "Topic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course_Inst",
                schema: "dbo",
                columns: table => new
                {
                    InstructorID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    Evaluate = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Inst", x => new { x.InstructorID, x.CourseID });
                    table.ForeignKey(
                        name: "FK_Course_Inst_Course_CourseID",
                        column: x => x.CourseID,
                        principalSchema: "dbo",
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_Inst_Instructor_InstructorID",
                        column: x => x.InstructorID,
                        principalSchema: "dbo",
                        principalTable: "Instructor",
                        principalColumn: "InstructorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stud_Course",
                schema: "dbo",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stud_Course", x => new { x.StudentID, x.CourseID });
                    table.ForeignKey(
                        name: "FK_Stud_Course_Course_CourseID",
                        column: x => x.CourseID,
                        principalSchema: "dbo",
                        principalTable: "Course",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stud_Course_Student_StudentID",
                        column: x => x.StudentID,
                        principalSchema: "dbo",
                        principalTable: "Student",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_TopicID",
                schema: "dbo",
                table: "Course",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_CourseID",
                schema: "dbo",
                table: "Course_Inst",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_DepartmentID",
                schema: "dbo",
                table: "Instructor",
                column: "DepartmentID",
                unique: true,
                filter: "[DepartmentID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_CourseID",
                schema: "dbo",
                table: "Stud_Course",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_DepartmentID",
                schema: "dbo",
                table: "Student",
                column: "DepartmentID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course_Inst",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Stud_Course",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Instructor",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Course",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Student",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Topic",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "dbo");
        }
    }
}
