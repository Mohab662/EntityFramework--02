using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_02.Migrations
{
    /// <inheritdoc />
    public partial class ByDataAnnotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topic",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Course");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Department",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Topic",
                newName: "Topics",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "InsId",
                schema: "dbo",
                table: "Department",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "DepId",
                schema: "dbo",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "DeptId",
                schema: "dbo",
                table: "Instructors",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "TopId",
                schema: "dbo",
                table: "Courses",
                newName: "CourseId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Department",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                schema: "dbo",
                table: "Department",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Topics",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                schema: "dbo",
                table: "Students",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FName",
                schema: "dbo",
                table: "Students",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                schema: "dbo",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                schema: "dbo",
                table: "Instructors",
                type: "Money",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Instructors",
                type: "varchar(10)",
                maxLength: 10,
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
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "Courses",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Courses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                schema: "dbo",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                schema: "dbo",
                table: "Department",
                column: "DepartmentId");

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
                name: "PK_Courses",
                schema: "dbo",
                table: "Courses",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                schema: "dbo",
                table: "Department");

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
                name: "PK_Courses",
                schema: "dbo",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Department",
                schema: "dbo",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Topics",
                schema: "dbo",
                newName: "Topic");

            migrationBuilder.RenameTable(
                name: "Students",
                schema: "dbo",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Instructors",
                schema: "dbo",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "Courses",
                schema: "dbo",
                newName: "Course");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Department",
                newName: "InsId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Student",
                newName: "DepId");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Instructor",
                newName: "DeptId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Course",
                newName: "TopId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "InsId",
                table: "Department",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Department",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topic",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "FName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "DepId",
                table: "Student",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Instructor",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Money");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "DeptId",
                table: "Instructor",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Instructor",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "TopId",
                table: "Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Course",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topic",
                table: "Topic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");
        }
    }
}
