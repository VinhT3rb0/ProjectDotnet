using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfApp2.Models;

public partial class MvvmloginDbContext : DbContext
{
    public MvvmloginDbContext()
    {
    }

    public MvvmloginDbContext(DbContextOptions<MvvmloginDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ghe> Ghes { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Phim> Phims { get; set; }

    public virtual DbSet<Phong> Phongs { get; set; }

    public virtual DbSet<ShowTime> ShowTimes { get; set; }

    public virtual DbSet<ShowTimeSetting> ShowTimeSettings { get; set; }

    public virtual DbSet<TaiKhoan1> TaiKhoan1s { get; set; }

    public virtual DbSet<TimeSetting> TimeSettings { get; set; }

    public virtual DbSet<TinhTrangGhe> TinhTrangGhes { get; set; }

    public virtual DbSet<Ve> Ves { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Admin\\SQLEXPRESS;Database=MVVMLoginDb;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ghe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ghe__3214EC07428E4CC7");

            entity.ToTable("Ghe");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.HangGhe)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdPhong).HasColumnName("idPhong");

            entity.HasOne(d => d.IdPhongNavigation).WithMany(p => p.Ghes)
                .HasForeignKey(d => d.IdPhong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ghe_Phong");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC073000A087");

            entity.ToTable("HoaDon");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.GiaVe).HasColumnType("money");
            entity.Property(e => e.IdKhachHang).HasMaxLength(50);
            entity.Property(e => e.IdNhanVien).HasMaxLength(50);
            entity.Property(e => e.ThoiGian).HasMaxLength(50);

            entity.HasOne(d => d.IdKhachHangNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdKhachHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HoaDon_KhachHang");

            entity.HasOne(d => d.IdNhanVienNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdNhanVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HoaDon_NhanVien");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07617C2FA5");

            entity.ToTable("KhachHang");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .HasColumnName("SDT");
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhanVien__3214EC07580DD309");

            entity.ToTable("NhanVien");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.ChucVu).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.MatKhau).HasMaxLength(50);
            entity.Property(e => e.NgaySinh).HasColumnType("smalldatetime");
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .HasColumnName("SDT");
            entity.Property(e => e.TaiKhoan).HasMaxLength(50);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<Phim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Phim__3214EC0794F37371");

            entity.ToTable("Phim");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DaoDien).HasMaxLength(50);
            entity.Property(e => e.HinhAnh)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
            entity.Property(e => e.QuocGia).HasMaxLength(50);
            entity.Property(e => e.TenPhim).HasMaxLength(50);
            entity.Property(e => e.TheLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<Phong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Phong__3214EC077E2E3814");

            entity.ToTable("Phong");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.SoLuongGhe).HasColumnName("soLuongGhe");
        });

        modelBuilder.Entity<ShowTime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ShowTime__3214EC07EEA67E5D");

            entity.ToTable("ShowTime");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.GiaVe).HasColumnType("money");

            entity.HasOne(d => d.Movie).WithMany(p => p.ShowTimes)
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShowTime_Phim");
        });

        modelBuilder.Entity<ShowTimeSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ShowTime__3214EC07D4886698");

            entity.ToTable("ShowTimeSetting");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ShowDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TaiKhoan1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TaiKhoan1");

            entity.Property(e => e.MatKhau).HasMaxLength(50);
            entity.Property(e => e.Quyen).HasMaxLength(50);
            entity.Property(e => e.TenDangNhap).HasMaxLength(50);
            entity.Property(e => e.TenNhanVien).HasMaxLength(50);
        });

        modelBuilder.Entity<TimeSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TimeSetting");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ShowDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TinhTrangGhe>(entity =>
        {
            entity.HasKey(e => e.IdGhe).HasName("PK__TinhTran__0C9F9BAA836D8004");

            entity.ToTable("TinhTrangGhe");

            entity.Property(e => e.IdGhe).ValueGeneratedNever();

            entity.HasOne(d => d.IdGheNavigation).WithOne(p => p.TinhTrangGhe)
                .HasForeignKey<TinhTrangGhe>(d => d.IdGhe)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TinhTrangGhe_Ghe");

            entity.HasOne(d => d.Showtime).WithMany(p => p.TinhTrangGhes)
                .HasForeignKey(d => d.ShowtimeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TinhTrangGhe_ShowTime");
        });

        modelBuilder.Entity<Ve>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ve__3214EC07A6C27A1F");

            entity.ToTable("Ve");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BillId).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("money");

            entity.HasOne(d => d.Bill).WithMany(p => p.Ves)
                .HasForeignKey(d => d.BillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ve_HoaDon");

            entity.HasOne(d => d.Phim).WithMany(p => p.Ves)
                .HasForeignKey(d => d.PhimId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ve_Phim");

            entity.HasOne(d => d.Phong).WithMany(p => p.Ves)
                .HasForeignKey(d => d.PhongId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ve_Phong");

            entity.HasOne(d => d.Seat).WithMany(p => p.Ves)
                .HasForeignKey(d => d.SeatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ve_Ghe");

            entity.HasOne(d => d.Showtime).WithMany(p => p.Ves)
                .HasForeignKey(d => d.ShowtimeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ve_ShowTime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
