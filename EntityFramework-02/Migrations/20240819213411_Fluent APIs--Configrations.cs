using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_02.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPIsConfigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Stud_Course");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Course_Inst");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Course_Inst");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Course_Inst");

            migrationBuilder.RenameTable(
                name: "Stud_Course",
                newName: "Stud_Course",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Course_Inst",
                newName: "Course_Inst",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Department",
                schema: "dbo",
                newName: "Departments",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "Topics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                schema: "dbo",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                schema: "dbo",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                schema: "dbo",
                table: "Instructors",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                schema: "dbo",
                table: "Instructors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                schema: "dbo",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Courses",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                schema: "dbo",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Top_ID",
                schema: "dbo",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Evaluate",
                schema: "dbo",
                table: "Course_Inst",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                schema: "dbo",
                table: "Departments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                schema: "dbo",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                computedColumnSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                schema: "dbo",
                table: "Departments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentId",
                schema: "dbo",
                table: "Students",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepartmentId",
                schema: "dbo",
                table: "Instructors",
                column: "DepartmentId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentId",
                schema: "dbo",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DepartmentId",
                schema: "dbo",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_ID",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                schema: "dbo",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                schema: "dbo",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                schema: "dbo",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Top_ID",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Stud_Course",
                schema: "dbo",
                newName: "Stud_Course");

            migrationBuilder.RenameTable(
                name: "Course_Inst",
                schema: "dbo",
                newName: "Course_Inst");

            migrationBuilder.RenameTable(
                name: "Departments",
                schema: "dbo",
                newName: "Department",
                newSchema: "dbo");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "Topics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                schema: "dbo",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AlterColumn<string>(
                name: "Adress",
                schema: "dbo",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                schema: "dbo",
                table: "Instructors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Courses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                schema: "dbo",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Stud_Course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Evaluate",
                table: "Course_Inst",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Course_Inst",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                schema: "dbo",
                table: "Department",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComputedColumnSql: "GETDATE()");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                schema: "dbo",
                table: "Department",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                schema: "dbo",
                table: "Department",
                column: "DepartmentId");
        }
    }
}
