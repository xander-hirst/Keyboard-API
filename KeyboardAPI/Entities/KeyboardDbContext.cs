using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class KeyboardDbContext : DbContext
    {
        public KeyboardDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public KeyboardDbContext(DbContextOptions<KeyboardDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<CherrySwitch> CherrySwitches { get; set; }
        public virtual DbSet<ConnectionType> ConnectionTypes { get; set; }
        public virtual DbSet<KeyLayout> KeyLayouts { get; set; }
        public virtual DbSet<KeyStyle> KeyStyles { get; set; }
        public virtual DbSet<Keyboard> Keyboards { get; set; }
        public virtual DbSet<KeyboardSize> KeyboardSizes { get; set; }
        public virtual DbSet<SwitchType> SwitchTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = Configuration.GetConnectionString("KeyboardDb");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.HasIndex(e => e.BrandId, "IX_Brand_Id");

                entity.Property(e => e.BrandId).HasColumnName("Brand_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CherrySwitch>(entity =>
            {
                entity.HasKey(e => e.Color)
                    .HasName("PK__Cherry_S__E11D38446A4B52A8");

                entity.ToTable("Cherry_Switch");

                entity.HasIndex(e => e.ActuationForceInG, "IX_Cherry_Switch_Actuation_Force");

                entity.HasIndex(e => e.BottomOutForceInG, "IX_Cherry_Switch_BottomOut_Force");

                entity.HasIndex(e => e.Color, "IX_Cherry_Switch_Color");

                entity.HasIndex(e => e.Color, "UQ__Cherry_S__E11D3845FD97FBDF")
                    .IsUnique();

                entity.Property(e => e.Color)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ActuationForceInG).HasColumnName("Actuation_Force_In_G");

                entity.Property(e => e.ActuatuationType)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Actuatuation_Type");

                entity.Property(e => e.BottomOutForceInG).HasColumnName("BottomOut_Force_In_G");
            });

            modelBuilder.Entity<ConnectionType>(entity =>
            {
                entity.ToTable("Connection_Type");

                entity.HasIndex(e => e.HasUsb, "IX_Connection_Type_HasUSB");

                entity.HasIndex(e => e.ConnectionTypeId, "IX_Connection_Type_Id");

                entity.HasIndex(e => e.IsWireless, "IX_Connection_Type_IsWireless");

                entity.Property(e => e.ConnectionTypeId).HasColumnName("Connection_Type_Id");

                entity.Property(e => e.HasUsb).HasColumnName("HasUSB");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KeyLayout>(entity =>
            {
                entity.ToTable("KeyLayout");

                entity.HasIndex(e => e.KeyLayoutId, "IX_KeyLayout_Id");

                entity.Property(e => e.KeyLayoutId).HasColumnName("KeyLayout_Id");

                entity.Property(e => e.Layout)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KeyStyle>(entity =>
            {
                entity.ToTable("KeyStyle");

                entity.HasIndex(e => e.KeyStyleId, "IX_KeyStyle_Id");

                entity.Property(e => e.KeyStyleId).HasColumnName("KeyStyle_Id");

                entity.Property(e => e.Style)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Keyboard>(entity =>
            {
                entity.ToTable("Keyboard");

                entity.HasIndex(e => e.BrandId, "IX_Keyboard_Brand_Id");

                entity.HasIndex(e => e.CherrySwitchColor, "IX_Keyboard_Cherry_Switch_Color");

                entity.HasIndex(e => e.ConnectionTypeId, "IX_Keyboard_Connection_Type_Id");

                entity.HasIndex(e => e.HasBacklighting, "IX_Keyboard_Has_Backlighting");

                entity.HasIndex(e => e.Id, "IX_Keyboard_Id");

                entity.HasIndex(e => e.KeyLayoutId, "IX_Keyboard_KeyLayout_Id");

                entity.HasIndex(e => e.KeyStyleId, "IX_Keyboard_KeyStyle_Id");

                entity.HasIndex(e => e.KeyboardSizeId, "IX_Keyboard_KeyboardSize_Id");

                entity.HasIndex(e => e.Price, "IX_Keyboard_Price");

                entity.HasIndex(e => e.SwitchTypeId, "IX_Keyboard_Switch_Type_Id");

                entity.Property(e => e.BrandId).HasColumnName("Brand_Id");

                entity.Property(e => e.CherrySwitchColor)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Cherry_Switch_Color");

                entity.Property(e => e.ConnectionTypeId).HasColumnName("Connection_Type_Id");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HasBacklighting).HasColumnName("Has_Backlighting");

                entity.Property(e => e.KeyLayoutId).HasColumnName("KeyLayout_Id");

                entity.Property(e => e.KeyStyleId).HasColumnName("KeyStyle_Id");

                entity.Property(e => e.KeyboardSizeId).HasColumnName("KeyboardSize_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnType("date")
                    .HasColumnName("Release_Date");

                entity.Property(e => e.SwitchTypeId).HasColumnName("Switch_Type_Id");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.Keyboards)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Brand_Id");

                entity.HasOne(d => d.CherrySwitchColorNavigation)
                    .WithMany(p => p.Keyboards)
                    .HasForeignKey(d => d.CherrySwitchColor)
                    .HasConstraintName("FK_Cherry_Switch_Color");

                entity.HasOne(d => d.ConnectionType)
                    .WithMany(p => p.Keyboards)
                    .HasForeignKey(d => d.ConnectionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Connection_Type_Id");

                entity.HasOne(d => d.KeyLayout)
                    .WithMany(p => p.Keyboards)
                    .HasForeignKey(d => d.KeyLayoutId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeyLayout_Id");

                entity.HasOne(d => d.KeyStyle)
                    .WithMany(p => p.Keyboards)
                    .HasForeignKey(d => d.KeyStyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeyStyle_Id");

                entity.HasOne(d => d.KeyboardSize)
                    .WithMany(p => p.Keyboards)
                    .HasForeignKey(d => d.KeyboardSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeyboardSize_Id");

                entity.HasOne(d => d.SwitchType)
                    .WithMany(p => p.Keyboards)
                    .HasForeignKey(d => d.SwitchTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Switch_Type_Id");
            });

            modelBuilder.Entity<KeyboardSize>(entity =>
            {
                entity.ToTable("KeyboardSize");

                entity.HasIndex(e => e.KeyboardSizeId, "IX_KeyboardSize_Id");

                entity.Property(e => e.KeyboardSizeId).HasColumnName("KeyboardSize_Id");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SwitchType>(entity =>
            {
                entity.ToTable("Switch_Type");

                entity.HasIndex(e => e.SwitchTypeId, "IX_Switch_Type_Id");

                entity.Property(e => e.SwitchTypeId).HasColumnName("Switch_Type_Id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
