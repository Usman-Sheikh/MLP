using MLP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MLP.Data
{
    public class MLPContext : DbContext
    {
        public MLPContext()
            : base("name=MLPContext")
        {
        }
        public DbSet<Content> Contents { get; set; }
        public DbSet<CourseInstructor> Course_Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Enrollment> Student_Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TeacherAssistant> TeacherAssistants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Content>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.OutComes)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.CourseInstructors)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Modules)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Enrollments)
                .WithRequired(e => e.Course)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.About)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.Cnic)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.FacebookUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .Property(e => e.TwitterName)
                .IsUnicode(false);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.CourseInstructors)
                .WithRequired(e => e.Instructor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Module>()
                .Property(e => e.ModuleName)
                .IsUnicode(false);

            modelBuilder.Entity<Module>()
                .HasMany(e => e.Contents)
                .WithRequired(e => e.Module)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.About)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Cnic)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FacebookUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.TwitterName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Enrollments)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TeacherAssistant>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherAssistant>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherAssistant>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherAssistant>()
                .Property(e => e.About)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherAssistant>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherAssistant>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherAssistant>()
                .Property(e => e.Cnic)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherAssistant>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherAssistant>()
                .Property(e => e.FacebookUrl)
                .IsUnicode(false);

            modelBuilder.Entity<TeacherAssistant>()
                .Property(e => e.TwitterName)
                .IsUnicode(false);
        }
    }
}