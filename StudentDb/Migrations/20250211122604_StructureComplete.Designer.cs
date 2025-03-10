﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentDb.Data;

#nullable disable

namespace StudentDb.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20250211122604_StructureComplete")]
    partial class StructureComplete
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentDb.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("DoorNo")
                        .HasColumnType("int");

                    b.Property<int>("Pin")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("StudentDb.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CourseName");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("StudentDb.Models.CourseLecturer", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "LecturerId");

                    b.HasIndex("LecturerId");

                    b.ToTable("CourseLecturer");
                });

            modelBuilder.Entity("StudentDb.Models.Lecturer", b =>
                {
                    b.Property<int>("LecturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LecturerId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LecturerName");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("LecturerId");

                    b.HasIndex("StudentId");

                    b.ToTable("Lecturer");
                });

            modelBuilder.Entity("StudentDb.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hobby")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("StudentName");

                    b.Property<int>("age")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("AddressId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentDb.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("StudentDb.Models.Subject", b =>
                {
                    b.Property<int>("SubjectrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectrId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("LecturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("SubjectName");

                    b.HasKey("SubjectrId");

                    b.HasIndex("CourseId");

                    b.HasIndex("LecturerId")
                        .IsUnique();

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("StudentDb.Models.CourseLecturer", b =>
                {
                    b.HasOne("StudentDb.Models.Course", "Course")
                        .WithMany("CourseLecturer")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentDb.Models.Lecturer", "Lecturer")
                        .WithMany("CourseLecturer")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Lecturer");
                });

            modelBuilder.Entity("StudentDb.Models.Lecturer", b =>
                {
                    b.HasOne("StudentDb.Models.Student", "Student")
                        .WithMany("Lecturers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentDb.Models.Student", b =>
                {
                    b.HasOne("StudentDb.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("StudentDb.Models.StudentCourse", b =>
                {
                    b.HasOne("StudentDb.Models.Course", "Course")
                        .WithMany("StudentCourse")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentDb.Models.Student", "Student")
                        .WithMany("StudentCourse")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentDb.Models.Subject", b =>
                {
                    b.HasOne("StudentDb.Models.Course", "Course")
                        .WithMany("Subjects")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentDb.Models.Lecturer", "Lecturers")
                        .WithOne("Subjects")
                        .HasForeignKey("StudentDb.Models.Subject", "LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Lecturers");
                });

            modelBuilder.Entity("StudentDb.Models.Course", b =>
                {
                    b.Navigation("CourseLecturer");

                    b.Navigation("StudentCourse");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("StudentDb.Models.Lecturer", b =>
                {
                    b.Navigation("CourseLecturer");

                    b.Navigation("Subjects")
                        .IsRequired();
                });

            modelBuilder.Entity("StudentDb.Models.Student", b =>
                {
                    b.Navigation("Lecturers");

                    b.Navigation("StudentCourse");
                });
#pragma warning restore 612, 618
        }
    }
}
