using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyboardAPI.Models.Configurations
{
    public class ConnectionTypeConfiguration : IEntityTypeConfiguration<ConnectionType>
    {
        public void Configure(EntityTypeBuilder<ConnectionType> builder)
        {
            builder.HasIndex(ct => ct.Id)
                .HasDatabaseName("IX_ConnectionType_Id");

            builder.HasIndex(ct => ct.HasUsb)
                .HasDatabaseName("IX_ConnectionType_HasUSB");

            builder.HasIndex(ct => ct.IsWireless)
                .HasDatabaseName("IX_ConnectionType_IsWireless");

            builder.Property(ct => ct.Type)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(ct => ct.HasUsb)
                .IsRequired()
                .HasColumnType("bit");

            builder.Property(ct => ct.IsWireless)
                .IsRequired()
                .HasColumnType("bit");
        }
    }
}