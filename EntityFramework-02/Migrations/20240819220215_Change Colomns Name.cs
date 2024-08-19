using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_02.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColomnsName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                schema: "dbo",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                schema: "dbo",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topics",
                schema: "dbo",
                table: "Topics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                schema: "dbo",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                schema: "dbo",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_ID",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Top_ID",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Topics",
                schema: "dbo",
                newName: "Topic",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Students",
                schema: "dbo",
                newName: "Student",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Instructors",
                schema: "dbo",
                newName: "Instructor",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Departments",
                schema: "dbo",
                newName: "Department",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Courses",
                schema: "dbo",
                newName: "Course",
                newSchema: "dbo");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DepartmentId",
                schema: "dbo",
                table: "Student",
                newName: "IX_Student_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_DepartmentId",
                schema: "dbo",
                table: "Instructor",
                newName: "IX_Instructor_DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topic",
                schema: "dbo",
                table: "Topic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                schema: "dbo",
                table: "Student",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                schema: "dbo",
                table: "Instructor",
                column: "InstructorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                schema: "dbo",
                table: "Department",
                column: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                schema: "dbo",
                table: "Course",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_DepartmentId",
                schema: "dbo",
                table: "Instructor",
                column: "DepartmentId",
                principalSchema: "dbo",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_DepartmentId",
                schema: "dbo",
                table: "Student",
                column: "DepartmentId",
                principalSchema: "dbo",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_DepartmentId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_DepartmentId",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topic",
                schema: "dbo",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                schema: "dbo",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                schema: "dbo",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Topic",
                schema: "dbo",
                newName: "Topics",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Student",
                schema: "dbo",
                newName: "Students",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Instructor",
                schema: "dbo",
                newName: "Instructors",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Department",
                schema: "dbo",
                newName: "Departments",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Course",
                schema: "dbo",
                newName: "Courses",
                newSchema: "dbo");

            migrationBuilder.RenameIndex(
                name: "IX_Student_DepartmentId",
                schema: "dbo",
                table: "Students",
                newName: "IX_Students_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_DepartmentId",
                schema: "dbo",
                table: "Instructors",
                newName: "IX_Instructors_DepartmentId");

            migrationBuilder.AddColumn<int>(
                name: "Top_ID",
                schema: "dbo",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topics",
                schema: "dbo",
                table: "Topics",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                schema: "dbo",
                table: "Students",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                schema: "dbo",
                table: "Instructors",
                column: "InstructorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                schema: "dbo",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                schema: "dbo",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_ID",
                schema: "dbo",
                table: "Courses",
                column: "Top_ID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_ID",
                schema: "dbo",
                table: "Courses",
                column: "Top_ID",
                principalSchema: "dbo",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                schema: "dbo",
                table: "Instructors",
                column: "DepartmentId",
                principalSchema: "dbo",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                schema: "dbo",
                table: "Students",
                column: "DepartmentId",
                principalSchema: "dbo",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
