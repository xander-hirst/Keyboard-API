using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyboardAPI.Models.Configurations
{
    public class KeyboardDesignConfiguration : IEntityTypeConfiguration<KeyboardDesign>
    {
        public void Configure(EntityTypeBuilder<KeyboardDesign> builder)
        {
            builder
                .HasIndex(kd => kd.Id)
                .HasDatabaseName("IX_KeyboardDesign_Id");

            builder
                .Property(kd => kd.Layout)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}

