using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentDb.Migrations
{
    /// <inheritdoc />
    public partial class dbsetadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseLecturer_Course_CourseId",
                table: "CourseLecturer");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseLecturer_Lecturer_LecturerId",
                table: "CourseLecturer");

            migrationBuilder.DropForeignKey(
                name: "FK_Lecturer_Students_StudentId",
                table: "Lecturer");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Address_AddressId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Course_CourseId",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Lecturer_LecturerId",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lecturer",
                table: "Lecturer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "Lecturer",
                newName: "Lecturers");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresss");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_LecturerId",
                table: "Subjects",
                newName: "IX_Subjects_LecturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_CourseId",
                table: "Subjects",
                newName: "IX_Subjects_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Lecturer_StudentId",
                table: "Lecturers",
                newName: "IX_Lecturers_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "SubjectrId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lecturers",
                table: "Lecturers",
                column: "LecturerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresss",
                table: "Addresss",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLecturer_Courses_CourseId",
                table: "CourseLecturer",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLecturer_Lecturers_LecturerId",
                table: "CourseLecturer",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "LecturerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lecturers_Students_StudentId",
                table: "Lecturers",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Addresss_AddressId",
                table: "Students",
                column: "AddressId",
                principalTable: "Addresss",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Courses_CourseId",
                table: "Subjects",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Lecturers_LecturerId",
                table: "Subjects",
                column: "LecturerId",
                principalTable: "Lecturers",
                principalColumn: "LecturerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseLecturer_Courses_CourseId",
                table: "CourseLecturer");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseLecturer_Lecturers_LecturerId",
                table: "CourseLecturer");

            migrationBuilder.DropForeignKey(
                name: "FK_Lecturers_Students_StudentId",
                table: "Lecturers");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Addresss_AddressId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Courses_CourseId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Lecturers_LecturerId",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lecturers",
                table: "Lecturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresss",
                table: "Addresss");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameTable(
                name: "Lecturers",
                newName: "Lecturer");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameTable(
                name: "Addresss",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_LecturerId",
                table: "Subject",
                newName: "IX_Subject_LecturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_CourseId",
                table: "Subject",
                newName: "IX_Subject_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Lecturers_StudentId",
                table: "Lecturer",
                newName: "IX_Lecturer_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "SubjectrId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lecturer",
                table: "Lecturer",
                column: "LecturerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLecturer_Course_CourseId",
                table: "CourseLecturer",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLecturer_Lecturer_LecturerId",
                table: "CourseLecturer",
                column: "LecturerId",
                principalTable: "Lecturer",
                principalColumn: "LecturerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lecturer_Students_StudentId",
                table: "Lecturer",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Course_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Address_AddressId",
                table: "Students",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Course_CourseId",
                table: "Subject",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Lecturer_LecturerId",
                table: "Subject",
                column: "LecturerId",
                principalTable: "Lecturer",
                principalColumn: "LecturerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
