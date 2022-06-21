using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace De16725_Again.Models
{
    public partial class QLBenhNhanContext : DbContext
    {
        public QLBenhNhanContext()
        {
        }

        public QLBenhNhanContext(DbContextOptions<QLBenhNhanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<KhoaKham> KhoaKhams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-JBJPHA3\\SQLEXPRESS;Initial Catalog=QLBenhNhan;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BenhNhan>(entity =>
            {
                entity.HasKey(e => e.Mabn)
                    .HasName("PK__BenhNhan__272369952EC6BD20");

                entity.ToTable("BenhNhan");

                entity.Property(e => e.Mabn)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Diachi).HasMaxLength(100);

                entity.Property(e => e.Hoten).HasMaxLength(50);

                entity.Property(e => e.Makhoa)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.SongayNv).HasColumnName("SongayNV");

                entity.HasOne(d => d.MakhoaNavigation)
                    .WithMany(p => p.BenhNhans)
                    .HasForeignKey(d => d.Makhoa)
                    .HasConstraintName("FK_BenhNhan_KhoaKham");
            });

            modelBuilder.Entity<KhoaKham>(entity =>
            {
                entity.HasKey(e => e.Makhoa)
                    .HasName("PK__KhoaKham__5E7F13834098C2F3");

                entity.ToTable("KhoaKham");

                entity.Property(e => e.Makhoa)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Tenkhoa).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
