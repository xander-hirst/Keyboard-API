using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyboardAPI.Models.Configurations
{
    public class MechanicalSwitchConfiguration : IEntityTypeConfiguration<MechanicalSwitch>
    {
        public void Configure(EntityTypeBuilder<MechanicalSwitch> builder)
        {
            builder.HasIndex(ms => ms.Color)
                .HasDatabaseName("[IX_MechanicalSwitch_Color]");

            builder.HasIndex(ms => ms.ActuationForceInG)
                .HasDatabaseName("IX_MechanicalSwitch_Actuation_Force");

            builder.HasIndex(ms => ms.BottomOutForceInG)
                .HasDatabaseName("IX_MechanicalSwitch_BottomOut_Force");

            builder.Property(ms => ms.Color)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false);

            builder.Property(ms => ms.ActuationType)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false);

            builder.Property(ms => ms.ActuationForceInG)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(ms => ms.BottomOutForceInG)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
