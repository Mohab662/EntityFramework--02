using EntityFramework_02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Configrations
{
    internal class TopicConfigration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> S)
        {
            S.ToTable("Topic", "dbo");
            S.HasKey(S => S.ID);



            S.Property(e => e.Name)
             .IsRequired(true)
             .HasColumnType("varchar")
             .HasAnnotation("StringLength", (50, 20));

            

        }
    }
}
