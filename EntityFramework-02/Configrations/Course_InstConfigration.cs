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
    internal class Course_InstConfigration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> S)
        {
            S.ToTable("Course_Inst", "dbo");
            S.HasNoKey();


            S.Property(e => e.Evaluate)
             .IsRequired(true)
             .HasColumnType("varchar")
             /*.HasAnnotation("StringLength", (50, 20))*/;
        }
    }
}
