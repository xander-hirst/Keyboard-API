using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyboardAPI.Models.Configurations
{
    public class KeyboardSizeConfiguration : IEntityTypeConfiguration<KeyboardSize>
    {
        public void Configure(EntityTypeBuilder<KeyboardSize> builder)
        {
            builder
                .HasIndex(ks => ks.Id)
                .HasDatabaseName("IX_KeyboardSize_Id");

            builder
                .Property(ks => ks.Size)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            builder
                .Property(ks => ks.NumKeys)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}

