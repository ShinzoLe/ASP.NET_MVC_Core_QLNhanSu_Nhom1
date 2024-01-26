using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace QL_NhanSu_nhom1.Models.NhanVien
{
    public partial class QL_NhanSuContext : DbContext
    {
        public QL_NhanSuContext()
        {
        }

        public QL_NhanSuContext(DbContextOptions<QL_NhanSuContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NhanVien> NhanViens { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MSI;Initial Catalog=QL_NhanSu;Persist Security Info=True;User ID=sa;Password=123");
            }
        }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv)
                    .HasMaxLength(20)
                    .HasColumnName("MaNV");

                entity.Property(e => e.Chucvu).HasMaxLength(50);

                entity.Property(e => e.Diachi).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(80);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.Hoten).HasMaxLength(80);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.TrangthaiNv)
                    .HasMaxLength(20)
                    .HasColumnName("TrangthaiNV");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
