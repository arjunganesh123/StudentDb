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

        }
    }
}
