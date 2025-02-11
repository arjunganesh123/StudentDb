using Microsoft.EntityFrameworkCore;
using StudentDb.Models;

namespace StudentDb.Data
{
    public class AppDataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        private readonly string _connectionstring;

        public AppDataContext()
        {
            _connectionstring = @"Server=ARJUN\SQLEXPRESS;Database=StudentDataBase;User Id=sa;Password=Password@123;TrustServerCertificate=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Student)
                .WithMany(sc => sc.StudentCourse)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(sc => sc.Course)
                .WithMany(sc => sc.StudentCourse)
                .HasForeignKey(sc => sc.CourseId);

            modelBuilder.Entity<CourseLecturer>()
                .HasKey(cl => new { cl.CourseId, cl.LecturerId });

            modelBuilder.Entity<CourseLecturer>()
                .HasOne(cl => cl.Course)
                .WithMany(cl => cl.CourseLecturer)
                .HasForeignKey(cl => cl.CourseId);

            modelBuilder.Entity<CourseLecturer>()
                .HasOne(cl => cl.Lecturer)
                .WithMany(cl => cl.CourseLecturer)
                .HasForeignKey(cl => cl.LecturerId);
        }
    }
}
