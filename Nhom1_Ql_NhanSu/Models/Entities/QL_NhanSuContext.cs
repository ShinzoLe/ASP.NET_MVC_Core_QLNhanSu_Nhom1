using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Nhom1_Ql_NhanSu.Models.Entities
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

        public virtual DbSet<Cv> Cvs { get; set; }
        public virtual DbSet<Dchinhsach> Dchinhsaches { get; set; }
        public virtual DbSet<KhoaDaoTao> KhoaDaoTaos { get; set; }
        public virtual DbSet<Kpi1> Kpi1s { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-73U63T3I\\TAM;Initial Catalog=QL_NhanSu;User ID=admin;Password=admin");
            }
        }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cv>(entity =>
            {
                entity.HasKey(e => e.MaCv);

                entity.ToTable("CV");

                entity.Property(e => e.MaCv)
                    .HasMaxLength(50)
                    .HasColumnName("MaCV");

                entity.Property(e => e.CongViec)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DiaChi).IsRequired();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GioiTinh)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NgayNopCv)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayNopCV");

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SDT");

                entity.Property(e => e.TinhTrang)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TrinhDoHocVan)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dchinhsach>(entity =>
            {
                entity.ToTable("Dchinhsach");

                entity.Property(e => e.Id).HasMaxLength(10);

                entity.Property(e => e.Class).HasMaxLength(50);

                entity.Property(e => e.Text).IsRequired();
            });

            modelBuilder.Entity<KhoaDaoTao>(entity =>
            {
                entity.HasKey(e => e.MaKhoa);

                entity.ToTable("KhoaDaoTao");

                entity.Property(e => e.MoTa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenKhoa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ThoiGianBatDau).HasColumnType("datetime");

                entity.Property(e => e.ThoiGianKetThuc).HasColumnType("datetime");
            });

            modelBuilder.Entity<Kpi1>(entity =>
            {
                entity.ToTable("KPI1");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DanhGiaKpi)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("DanhGiaKPI");

                entity.Property(e => e.DiLamDayDu)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DiLamDungGio)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.HoanThanhTotCongViec)
                    .IsRequired()
                    .HasMaxLength(200);
            });

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
