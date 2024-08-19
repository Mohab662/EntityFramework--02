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
    internal class InstructorConfigration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> S)
        {
            S.ToTable("Instructor", "dbo");
            S.HasKey(e => e.InstructorId);

            S.Property(e => e.InstructorId)
             .UseIdentityColumn(10, 10);

            S.Property(e => e.Name)
             .IsRequired(true)
             .HasColumnType("varchar")
             .HasAnnotation("StringLength", (50, 20));

            S.Property(e => e.Adress)
             .IsRequired(true)
             .HasColumnType("varchar")
             .HasAnnotation("StringLength", (40, 10));

            S.Property(e => e.Salary)
             .HasAnnotation("Range", (2000, 10000));

            S.Property(e => e.Bouns)
             .IsRequired(true);
        }
    }
}
