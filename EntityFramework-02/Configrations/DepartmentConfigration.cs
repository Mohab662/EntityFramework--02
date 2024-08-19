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
    internal class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> S)
        {
            S.ToTable("Department", "dbo");
            S.HasKey(e => e.DepartmentId);

            S.Property(e => e.DepartmentId)
             .UseIdentityColumn(10, 10);

            S.Property(e => e.Name)
             .IsRequired(true)
             .HasColumnType("varchar")
             .HasAnnotation("StringLength", (50, 20));

            S.Property(e => e.HiringDate)
             .HasComputedColumnSql("GETDATE()");
        }
    }
}
