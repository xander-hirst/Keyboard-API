using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace KeyboardAPI.Models
{
    public partial class KeyboardDbContext : DbContext
    {
        public KeyboardDbContext()
        {
        }

        public KeyboardDbContext(DbContextOptions<KeyboardDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<ConnectionType> ConnectionTypes { get; set; }
        public virtual DbSet<KeyLayout> KeyLayouts { get; set; }
        public virtual DbSet<Keyboard> Keyboards { get; set; }
        public virtual DbSet<KeyboardDesign> KeyboardDesigns { get; set; }
        public virtual DbSet<KeyboardSize> KeyboardSizes { get; set; }
        public virtual DbSet<MechanicalSwitch> MechanicalSwitches { get; set; }
        public virtual DbSet<SwitchMechanism> SwitchMechanisms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=REN-L-F2MS2TR;Database=KeyboardDb;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.HasIndex(e => e.Id, "IX_Brand_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConnectionType>(entity =>
            {
                entity.ToTable("ConnectionType");

                entity.HasIndex(e => e.HasUsb, "IX_ConnectionType_HasUSB");

                entity.HasIndex(e => e.Id, "IX_ConnectionType_Id");

                entity.HasIndex(e => e.IsWireless, "IX_ConnectionType_IsWireless");

                entity.Property(e => e.HasUsb).HasColumnName("HasUSB");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KeyLayout>(entity =>
            {
                entity.ToTable("KeyLayout");

                entity.HasIndex(e => e.Id, "IX_KeyLayout_Id");

                entity.Property(e => e.Style)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Keyboard>(entity =>
            {
                entity.ToTable("Keyboard");

                entity.HasIndex(e => e.BrandId, "IX_Keyboard_Brand_Id");

                entity.HasIndex(e => e.ConnectionTypeId, "IX_Keyboard_ConnectionType_Id");

                entity.HasIndex(e => e.HasBacklighting, "IX_Keyboard_Has_Backlighting");

                entity.HasIndex(e => e.Id, "IX_Keyboard_Id");

                entity.HasIndex(e => e.KeyLayoutId, "IX_Keyboard_KeyLayout_Id");

                entity.HasIndex(e => e.KeyboardDesignId, "IX_Keyboard_KeyboardDesign_Id");

                entity.HasIndex(e => e.KeyboardSizeId, "IX_Keyboard_KeyboardSize_Id");

                entity.HasIndex(e => e.MechanicalSwitchColor, "IX_Keyboard_MechanicalSwitch_Color");

                entity.HasIndex(e => e.Price, "IX_Keyboard_Price");

                entity.HasIndex(e => e.SwitchMechanismId, "IX_Keyboard_SwitchMechanism_Id");

                entity.Property(e => e.BrandId).HasColumnName("Brand_Id");

                entity.Property(e => e.ConnectionTypeId).HasColumnName("ConnectionType_Id");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HasBacklighting).HasColumnName("Has_Backlighting");

                entity.Property(e => e.KeyLayoutId).HasColumnName("KeyLayout_Id");

                entity.Property(e => e.KeyboardDesignId).HasColumnName("KeyboardDesign_Id");

                entity.Property(e => e.KeyboardSizeId).HasColumnName("KeyboardSize_Id");

                entity.Property(e => e.MechanicalSwitchColor)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MechanicalSwitch_Color");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnType("date")
                    .HasColumnName("Release_Date");

                entity.Property(e => e.SwitchMechanismId).HasColumnName("SwitchMechanism_Id");

                entity.HasOne(d => d.Brand)
                    .WithMany()
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Brand_Id");

                entity.HasOne(d => d.ConnectionType)
                    .WithMany()
                    .HasForeignKey(d => d.ConnectionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConnectionType_Id");

                entity.HasOne(d => d.KeyLayout)
                    .WithMany()
                    .HasForeignKey(d => d.KeyLayoutId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeyLayout_Id");

                entity.HasOne(d => d.KeyboardDesign)
                    .WithMany()
                    .HasForeignKey(d => d.KeyboardDesignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeyboardDesign_Id");

                entity.HasOne(d => d.KeyboardSize)
                    .WithMany()
                    .HasForeignKey(d => d.KeyboardSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KeyboardSize_Id");

                entity.HasOne(d => d.MechanicalSwitchColorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MechanicalSwitchColor)
                    .HasConstraintName("FK_MechanicalSwitch_Color");

                entity.HasOne(d => d.SwitchMechanism)
                    .WithMany()
                    .HasForeignKey(d => d.SwitchMechanismId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SwitchMechanism_Id");
            });

            modelBuilder.Entity<KeyboardDesign>(entity =>
            {
                entity.ToTable("KeyboardDesign");

                entity.HasIndex(e => e.Id, "IX_KeyLayout_Id");

                entity.Property(e => e.Layout)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KeyboardSize>(entity =>
            {
                entity.ToTable("KeyboardSize");

                entity.HasIndex(e => e.Id, "IX_KeyboardSize_Id");

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MechanicalSwitch>(entity =>
            {
                entity.HasKey(e => e.Color)
                    .HasName("PK__Mechanic__E11D3844080239E6");

                entity.ToTable("MechanicalSwitch");

                entity.HasIndex(e => e.ActuationForceInG, "IX_MechanicalSwitch_Actuation_Force");

                entity.HasIndex(e => e.BottomOutForceInG, "IX_MechanicalSwitch_BottomOut_Force");

                entity.HasIndex(e => e.Color, "IX_MechanicalSwitch_Color");

                entity.HasIndex(e => e.Color, "UQ__Mechanic__E11D38458E18D9FE")
                    .IsUnique();

                entity.Property(e => e.Color)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ActuationForceInG).HasColumnName("Actuation_Force_In_G");

                entity.Property(e => e.ActuationType)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Actuation_Type");

                entity.Property(e => e.BottomOutForceInG).HasColumnName("BottomOut_Force_In_G");
            });

            modelBuilder.Entity<SwitchMechanism>(entity =>
            {
                entity.ToTable("SwitchMechanism");

                entity.HasIndex(e => e.Id, "IX_SwitchMechanism_Id");

                entity.Property(e => e.Mechanism)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
