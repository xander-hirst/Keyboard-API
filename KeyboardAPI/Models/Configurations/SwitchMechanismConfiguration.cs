using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyboardAPI.Models.Configurations
{
    public class SwitchMechanismConfiguration : IEntityTypeConfiguration<SwitchMechanism>
    {
        public void Configure(EntityTypeBuilder<SwitchMechanism> builder)
        {
            builder
                .HasIndex(ks => ks.Id)
                .HasDatabaseName("IX_SwitchMechanism_Id");

            builder
                .Property(ks => ks.Mechanism)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}