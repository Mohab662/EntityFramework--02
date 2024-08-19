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
    internal class Stud_CourseConfigration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> S)
        {
            S.ToTable("Stud_Course", "dbo");
            S.HasNoKey();

            S.Property(e => e.Grade)
             .HasAnnotation("Range", (0, 100));
        }
    }
}
