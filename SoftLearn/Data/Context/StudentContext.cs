using Microsoft.EntityFrameworkCore;
using SoftLearn.Data.Entities;
using System.Reflection;

namespace SoftLearn.Data.Context
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Goat");
            modelBuilder.Entity<Student>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Student>().HasKey(c => c.Id);
            modelBuilder.Entity<Student>().Property(c => c.Name).IsRequired().HasMaxLength(5).HasColumnName("FullName");
        }

        public DbSet<Student> Students { get; set; }
    }
}
