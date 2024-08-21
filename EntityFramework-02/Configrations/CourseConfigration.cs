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
    internal class CourseConfigration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> S)
        {
            S.ToTable("Course", "dbo");
            S.HasKey(e => e.CourseID);



            S.Property(e => e.Name)
             .IsRequired(true)
             .HasColumnType("varchar")
             .HasAnnotation("StringLength", (50, 20));

            S.Property(e => e.Description)
             .IsRequired(true)
             .HasColumnType("varchar")
             .HasAnnotation("StringLength", (200, 300));

            S.Property(e => e.Duration)
             .HasAnnotation("Range", (2, 16));

            
                
        }
    }
}
