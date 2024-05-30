using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

public partial class VerssclubContext : DbContext
{
    public VerssclubContext()
    {
    }

    public VerssclubContext(DbContextOptions<VerssclubContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chatlieu> Chatlieus { get; set; }

    public virtual DbSet<Chucvu> Chucvus { get; set; }

    public virtual DbSet<Giohang> Giohangs { get; set; }

    public virtual DbSet<Giohangct> Giohangcts { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Loai> Loais { get; set; }

    public virtual DbSet<Mau> Maus { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Sanphamct> Sanphamcts { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<Thuonghieu> Thuonghieus { get; set; }

    public virtual DbSet<Xuatxu> Xuatxus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=HOANGTHANHGIANG\\SQLEXPRESS;Initial Catalog=VERSSCLUB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chatlieu>(entity =>
        {
            entity.HasKey(e => e.Machatlieu);

            entity.ToTable("CHATLIEU");

            entity.Property(e => e.Machatlieu)
                .ValueGeneratedNever()
                .HasColumnName("MACHATLIEU");
            entity.Property(e => e.Tenchatlieu)
                .HasMaxLength(50)
                .HasColumnName("TENCHATLIEU");
        });

        modelBuilder.Entity<Chucvu>(entity =>
        {
            entity.HasKey(e => e.Machucvu);

            entity.ToTable("CHUCVU");

            entity.Property(e => e.Machucvu)
                .ValueGeneratedNever()
                .HasColumnName("MACHUCVU");
            entity.Property(e => e.Vaitro)
                .HasMaxLength(50)
                .HasColumnName("VAITRO");
        });

        modelBuilder.Entity<Giohang>(entity =>
        {
            entity.HasKey(e => e.Makh);

            entity.ToTable("GIOHANG");

            entity.Property(e => e.Makh)
                .ValueGeneratedNever()
                .HasColumnName("MAKH");

            entity.HasOne(d => d.MakhNavigation).WithOne(p => p.Giohang)
                .HasForeignKey<Giohang>(d => d.Makh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GIOHANG_KHACHHANG");
        });

        modelBuilder.Entity<Giohangct>(entity =>
        {
            entity.HasKey(e => e.Maghtct);

            entity.ToTable("GIOHANGCT");

            entity.Property(e => e.Maghtct)
                .ValueGeneratedNever()
                .HasColumnName("MAGHTCT");
            entity.Property(e => e.Maspct).HasColumnName("MASPCT");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makh);

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.Makh)
                .ValueGeneratedNever()
                .HasColumnName("MAKH");
            entity.Property(e => e.Diachi)
                .IsUnicode(false)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Gioitinh).HasColumnName("GIOITINH");
            entity.Property(e => e.Hoten)
                .HasMaxLength(50)
                .HasColumnName("HOTEN");
            entity.Property(e => e.Matkhau)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MATKHAU");
            entity.Property(e => e.Ngaysinh).HasColumnName("NGAYSINH");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
        });

        modelBuilder.Entity<Loai>(entity =>
        {
            entity.HasKey(e => e.Maloai);

            entity.ToTable("LOAI");

            entity.Property(e => e.Maloai)
                .ValueGeneratedNever()
                .HasColumnName("MALOAI");
            entity.Property(e => e.Tenloai)
                .HasMaxLength(50)
                .HasColumnName("TENLOAI");
        });

        modelBuilder.Entity<Mau>(entity =>
        {
            entity.HasKey(e => e.Mamau);

            entity.ToTable("MAU");

            entity.Property(e => e.Mamau)
                .ValueGeneratedNever()
                .HasColumnName("MAMAU");
            entity.Property(e => e.Mausac)
                .HasMaxLength(50)
                .HasColumnName("MAUSAC");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv);

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.Manv)
                .ValueGeneratedNever()
                .HasColumnName("MANV");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Machucvu).HasColumnName("MACHUCVU");
            entity.Property(e => e.Matkhau)
                .IsUnicode(false)
                .HasColumnName("MATKHAU");
            entity.Property(e => e.Namsinh).HasColumnName("NAMSINH");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Tennhanvien)
                .HasMaxLength(50)
                .HasColumnName("TENNHANVIEN");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MachucvuNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Machucvu)
                .HasConstraintName("FK_NHANVIEN_CHUCVU");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Masp);

            entity.ToTable("SANPHAM");

            entity.Property(e => e.Masp)
                .ValueGeneratedNever()
                .HasColumnName("MASP");
            entity.Property(e => e.Tensanpham)
                .HasMaxLength(50)
                .HasColumnName("TENSANPHAM");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");
        });

        modelBuilder.Entity<Sanphamct>(entity =>
        {
            entity.HasKey(e => e.Maspct);

            entity.ToTable("SANPHAMCT");

            entity.Property(e => e.Maspct)
                .ValueGeneratedNever()
                .HasColumnName("MASPCT");
            entity.Property(e => e.Gia).HasColumnName("GIA");
            entity.Property(e => e.Imgurl)
                .IsUnicode(false)
                .HasColumnName("IMGURL");
            entity.Property(e => e.Machatlieu).HasColumnName("MACHATLIEU");
            entity.Property(e => e.Maloai).HasColumnName("MALOAI");
            entity.Property(e => e.Mamau).HasColumnName("MAMAU");
            entity.Property(e => e.Masize).HasColumnName("MASIZE");
            entity.Property(e => e.Masp).HasColumnName("MASP");
            entity.Property(e => e.Mathuonghieu).HasColumnName("MATHUONGHIEU");
            entity.Property(e => e.Maxuatxu).HasColumnName("MAXUATXU");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MachatlieuNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Machatlieu)
                .HasConstraintName("FK_SANPHAMCT_CHATLIEU");

            entity.HasOne(d => d.MaloaiNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Maloai)
                .HasConstraintName("FK_SANPHAMCT_LOAI");

            entity.HasOne(d => d.MamauNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Mamau)
                .HasConstraintName("FK_SANPHAMCT_MAU");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Masp)
                .HasConstraintName("FK_SANPHAMCT_SANPHAM");

            entity.HasOne(d => d.MathuonghieuNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Mathuonghieu)
                .HasConstraintName("FK_SANPHAMCT_THUONGHIEU");

            entity.HasOne(d => d.MaxuatxuNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Maxuatxu)
                .HasConstraintName("FK_SANPHAMCT_XUATXU");
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SIZE");

            entity.Property(e => e.Masize).HasColumnName("MASIZE");
            entity.Property(e => e.Size1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SIZE");
        });

        modelBuilder.Entity<Thuonghieu>(entity =>
        {
            entity.HasKey(e => e.Mathuonghieu);

            entity.ToTable("THUONGHIEU");

            entity.Property(e => e.Mathuonghieu)
                .ValueGeneratedNever()
                .HasColumnName("MATHUONGHIEU");
            entity.Property(e => e.Tenthuonghieu)
                .HasMaxLength(50)
                .HasColumnName("TENTHUONGHIEU");
        });

        modelBuilder.Entity<Xuatxu>(entity =>
        {
            entity.HasKey(e => e.Maxuatxu);

            entity.ToTable("XUATXU");

            entity.Property(e => e.Maxuatxu)
                .ValueGeneratedNever()
                .HasColumnName("MAXUATXU");
            entity.Property(e => e.Diadiemxuatxu).HasColumnName("DIADIEMXUATXU");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
