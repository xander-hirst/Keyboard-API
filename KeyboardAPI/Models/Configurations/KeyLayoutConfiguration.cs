using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyboardAPI.Models.Configurations
{
    public class KeyLayoutConfiguration : IEntityTypeConfiguration<KeyLayout>
    {
        public void Configure(EntityTypeBuilder<KeyLayout> builder)
        {
            builder
                .HasIndex(kl => kl.Id)
                .HasDatabaseName("IX_KeyLayout_Id");

            builder
                .Property(kl => kl.Style)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false);
        }
    }
}


