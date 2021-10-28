using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyboardAPI.Models.Configurations
{
    public class KeyboardConfiguration : IEntityTypeConfiguration<Keyboard>
    {
        public void Configure(EntityTypeBuilder<Keyboard> builder)
        {
            builder.HasIndex(k => k.Id)
                .HasDatabaseName("IX_Keyboard_Id");

            builder.HasIndex(k => k.BrandId)
                .HasDatabaseName("IX_Keyboard_Brand_Id");

            builder.HasIndex(k => k.Price)
                .HasDatabaseName("IX_Keyboard_Price");

            builder.HasIndex(k => k.HasBacklighting)
                .HasDatabaseName("IX_Keyboard_Has_Backlighting");

            builder.HasIndex(k => k.KeyLayoutId)
                .HasDatabaseName("IX_Keyboard_KeyLayout_Id");

            builder.HasIndex(k => k.KeyboardDesignId)
                .HasDatabaseName("IX_Keyboard_KeyboardDesign_Id");

            builder.HasIndex(k => k.KeyboardSizeId)
                .HasDatabaseName("IX_Keyboard_KeyboardSize_Id");

            builder.HasIndex(k => k.SwitchMechanismId)
                .HasDatabaseName("IX_Keyboard_SwitchMechanism_Id");

            builder.HasIndex(k => k.MechanicalSwitchColor)
                .HasDatabaseName("IX_Keyboard_MechanicalSwitch_Color");

            builder.HasIndex(k => k.ConnectionTypeId)
                .HasDatabaseName("IX_Keyboard_ConnectionType_Id");

            builder.Property(k => k.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(k => k.Price)
                .HasColumnType("smallmoney");

            builder.Property(k => k.Description)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(k => k.ReleaseDate)
                .HasColumnType("date");

            builder.Property(k => k.HasBacklighting)
                .HasColumnType("bit");

            builder
                .HasOne(keyboard => keyboard.Brand)
                //.WithMany(brand => brand.Keyboards)
                .WithMany()
                .HasForeignKey(keyboard => keyboard.BrandId);

            builder
                .HasOne(keyboard => keyboard.ConnectionType)
                .WithMany()
                .HasForeignKey(keyboard => keyboard.ConnectionTypeId);

            builder
                .HasOne(keyboard => keyboard.KeyLayout)
                .WithMany()
                .HasForeignKey(keyboard => keyboard.KeyLayoutId);

            builder
                .HasOne(keyboard => keyboard.KeyboardDesign)
                .WithMany()
                .HasForeignKey(keyboard => keyboard.KeyboardDesignId);

            builder
                .HasOne(keyboard => keyboard.KeyboardSize)
                .WithMany()
                .HasForeignKey(keyboard => keyboard.KeyboardSizeId);

            builder
                .HasOne(keyboard => keyboard.MechanicalSwitchColorNavigation)
                .WithMany()
                .HasForeignKey(keyboard => keyboard.MechanicalSwitchColor);

            builder
                .HasOne(keyboard => keyboard.SwitchMechanism)
                .WithMany()
                .HasForeignKey(keyboard => keyboard.SwitchMechanismId);
        }
    }
}
