using EntityFramework_02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Configrations
{
    internal class StudentConfigration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.ToTable("Student", "dbo");
            S.HasKey(S => S.StudentId);

            S.Property(e => e.StudentId)
             .UseIdentityColumn(10, 10);

            S.Property(e => e.FName)
             .IsRequired(true)
             .HasColumnType("varchar")
             .HasAnnotation("StringLength", (50, 20));

            S.Property(e => e.LName)
             .IsRequired(true)
             .HasColumnType("varchar")
             .HasAnnotation("StringLength", (50, 20));

            S.Property(e => e.Age)
             .HasAnnotation("Range", (21, 90));

            S.Property(e => e.Address)
             .IsRequired(true);
        }
    }
}
