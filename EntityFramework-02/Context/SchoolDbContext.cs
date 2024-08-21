using EntityFramework_02.Configrations;
using EntityFramework_02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Context
{
    internal class SchoolDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = SchoolDataBase02 ; Trusted_Connection=True;TrustServerCertificate=True;");
        }

        #region Way(1)
        public DbSet<Course> Course { get; set; }
        public DbSet<Course_Inst> Course_Inst { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Topic> Topic { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Way(3)
            //modelBuilder.Entity<Student>(S =>
            //    {
            //        S.ToTable("Students", "dbo");
            //        S.HasKey();

            //        S.Property(e => e.StudentId)
            //         .UseIdentityColumn(10, 10);

            //        S.Property(e => e.FName)
            //         .IsRequired(true)
            //         .HasColumnType("varchar")
            //         .HasAnnotation("StringLength", (50, 20));

            //        S.Property(e => e.LName)
            //         .IsRequired(true)
            //         .HasColumnType("varchar")
            //         .HasAnnotation("StringLength", (50, 20));

            //        S.Property(e => e.Age)
            //         .HasAnnotation("Range", (21, 90));

            //        S.Property(e => e.Address)
            //         .IsRequired(true);

            //    });

            //modelBuilder.Entity<Topic>(S =>
            //{
            //    S.ToTable("Students", "dbo");
            //    S.HasKey();

            //    S.Property(e => e.Id)
            //     .UseIdentityColumn(10, 10);

            //    S.Property(e => e.Name)
            //     .IsRequired(true)
            //     .HasColumnType("varchar")
            //     .HasAnnotation("StringLength", (50, 20));

            //});

            //modelBuilder.Entity<Department>(S =>
            //{
            //    S.ToTable("Departments", "dbo");
            //    S.HasKey();

            //    S.Property(e => e.DepartmentId)
            //     .UseIdentityColumn(10, 10);

            //    S.Property(e => e.Name)
            //     .IsRequired(true)
            //     .HasColumnType("varchar")
            //     .HasAnnotation("StringLength", (50, 20));

            //    S.Property(e => e.HiringDate)
            //     .HasComputedColumnSql("GETDATE()");

            //});

            //modelBuilder.Entity<Instructor>(S =>
            //{
            //    S.ToTable("Instructors", "dbo");
            //    S.HasKey();

            //    S.Property(e => e.InstructorId)
            //     .UseIdentityColumn(10, 10);

            //    S.Property(e => e.Name)
            //     .IsRequired(true)
            //     .HasColumnType("varchar")
            //     .HasAnnotation("StringLength", (50, 20));

            //    S.Property(e => e.Adress)
            //     .IsRequired(true)
            //     .HasColumnType("varchar")
            //     .HasAnnotation("StringLength", (40, 10));

            //    S.Property(e => e.Salary)
            //     .HasAnnotation("Range", (2000, 10000));

            //    S.Property(e => e.Bouns)
            //     .IsRequired(true);

            //});

            //modelBuilder.Entity<Course>(S =>
            //{
            //    S.ToTable("Courses", "dbo");
            //    S.HasKey();

            //    S.Property(e => e.CourseId)
            //     .UseIdentityColumn(10, 10);

            //    S.Property(e => e.Name)
            //     .IsRequired(true)
            //     .HasColumnType("varchar")
            //     .HasAnnotation("StringLength", (50, 20));

            //    S.Property(e => e.Description)
            //     .IsRequired(true)
            //     .HasColumnType("varchar")
            //     .HasAnnotation("StringLength", (200, 300));

            //    S.Property(e => e.Duration)
            //     .HasAnnotation("Range", (2, 16));

            //});

            //modelBuilder.Entity<Stud_Course>(S =>
            //{
            //    S.ToTable("Stud_Course", "dbo");
            //    S.HasNoKey();

            //    S.Property(e => e.Grade)
            //     .HasAnnotation("Range", (0, 100));

            //});

            //modelBuilder.Entity<Course_Inst>(S =>
            //{
            //    S.ToTable("Course_Inst", "dbo");
            //    S.HasNoKey();


            //    S.Property(e => e.Evaluate)
            //     .IsRequired(true)
            //     .HasColumnType("varchar")
            //     .HasAnnotation("StringLength", (50, 20));

            //}); 
            #endregion


            //modelBuilder.Entity<Course>()
            //            .HasOne(D => D.Topic)
            //            .WithOne(E => E.Course)
            //            .HasForeignKey<Course>(e => e.Top_ID)
            //            .IsRequired();

            modelBuilder.ApplyConfiguration(new DepartmentConfigration());
            modelBuilder.ApplyConfiguration(new StudentConfigration());
            modelBuilder.ApplyConfiguration(new TopicConfigration());
            modelBuilder.ApplyConfiguration(new CourseConfigration());
            modelBuilder.ApplyConfiguration(new InstructorConfigration());
            modelBuilder.ApplyConfiguration(new Course_InstConfigration());
            modelBuilder.ApplyConfiguration(new Stud_CourseConfigration());

            modelBuilder.Entity<Stud_Course>()
             .HasKey(sc => new { sc.StudentID, sc.CourseID });


            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(sc => sc.StudentID);

            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(sc => sc.CourseID);


            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.InstructorID, ci.CourseID });

            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.CourseInstructors)
                .HasForeignKey(ci => ci.InstructorID);


            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInstructors)
                .HasForeignKey(ci => ci.CourseID);


            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithOne(i => i.Department)
                .HasForeignKey<Instructor>(i => i.DepartmentID);

            


            base.OnModelCreating(modelBuilder);
        }

    }
}
