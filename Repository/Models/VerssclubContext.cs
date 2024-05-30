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

    public virtual DbSet<Danhgium> Danhgia { get; set; }

    public virtual DbSet<Giohang> Giohangs { get; set; }

    public virtual DbSet<Giohangct> Giohangcts { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Hoadonct> Hoadoncts { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Loai> Loais { get; set; }

    public virtual DbSet<Mau> Maus { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Productdiscount> Productdiscounts { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Sanphamct> Sanphamcts { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<Thanhtoan> Thanhtoans { get; set; }

    public virtual DbSet<Thuonghieu> Thuonghieus { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    public virtual DbSet<Xuatxu> Xuatxus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=hoangthanhgiang\\sqlexpress;Initial Catalog=VERSSCLUB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chatlieu>(entity =>
        {
            entity.HasKey(e => e.Machatlieu).HasName("PK__CHATLIEU__80F939F813A47416");

            entity.ToTable("CHATLIEU");

            entity.Property(e => e.Machatlieu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MACHATLIEU");
            entity.Property(e => e.Tenchatlieu)
                .HasMaxLength(50)
                .HasColumnName("TENCHATLIEU");
        });

        modelBuilder.Entity<Chucvu>(entity =>
        {
            entity.HasKey(e => e.Machucvu).HasName("PK__CHUCVU__9FA9FD6A7CBD95BE");

            entity.ToTable("CHUCVU");

            entity.Property(e => e.Machucvu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MACHUCVU");
            entity.Property(e => e.Vaitro)
                .HasMaxLength(50)
                .HasColumnName("VAITRO");
        });

        modelBuilder.Entity<Danhgium>(entity =>
        {
            entity.HasKey(e => e.Madanhgia).HasName("PK__DANHGIA__8597D60A7BE0A90B");

            entity.ToTable("DANHGIA");

            entity.Property(e => e.Madanhgia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MADANHGIA");
            entity.Property(e => e.Binhluan).HasColumnName("BINHLUAN");
            entity.Property(e => e.Hinhanh)
                .IsUnicode(false)
                .HasColumnName("HINHANH");
            entity.Property(e => e.Makh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAKH");
            entity.Property(e => e.Maspct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASPCT");
            entity.Property(e => e.Ngaydang).HasColumnName("NGAYDANG");
            entity.Property(e => e.Sosao).HasColumnName("SOSAO");

            entity.HasOne(d => d.MakhNavigation).WithMany(p => p.Danhgia)
                .HasForeignKey(d => d.Makh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DANHGIA__MAKH__1BC821DD");

            entity.HasOne(d => d.MaspctNavigation).WithMany(p => p.Danhgia)
                .HasForeignKey(d => d.Maspct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DANHGIA__MASPCT__1CBC4616");
        });

        modelBuilder.Entity<Giohang>(entity =>
        {
            entity.HasKey(e => e.Makh).HasName("PK__GIOHANG__603F592CB7F9DAF2");

            entity.ToTable("GIOHANG");

            entity.Property(e => e.Makh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAKH");

            entity.HasOne(d => d.MakhNavigation).WithOne(p => p.Giohang)
                .HasForeignKey<Giohang>(d => d.Makh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GIOHANG_KHACHHANG");
        });

        modelBuilder.Entity<Giohangct>(entity =>
        {
            entity.HasKey(e => e.Maghct).HasName("PK__GIOHANGC__0CCE71FE27BF5E53");

            entity.ToTable("GIOHANGCT");

            entity.Property(e => e.Maghct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAGHCT");
            entity.Property(e => e.Makh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAKH");
            entity.Property(e => e.Maspct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASPCT");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");

            entity.HasOne(d => d.MakhNavigation).WithMany(p => p.Giohangcts)
                .HasForeignKey(d => d.Makh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GIOHANGCT__MAKH__123EB7A3");

            entity.HasOne(d => d.MaspctNavigation).WithMany(p => p.Giohangcts)
                .HasForeignKey(d => d.Maspct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GIOHANGCT__MASPC__1332DBDC");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Mahd).HasName("PK__HOADON__603F20CE82D3DF24");

            entity.ToTable("HOADON");

            entity.Property(e => e.Mahd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAHD");
            entity.Property(e => e.Ghichu)
                .HasMaxLength(50)
                .HasColumnName("GHICHU");
            entity.Property(e => e.Magiamgia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAGIAMGIA");
            entity.Property(e => e.Makh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAKH");
            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MANV");
            entity.Property(e => e.Ngaytao)
                .HasColumnType("datetime")
                .HasColumnName("NGAYTAO");
            entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MagiamgiaNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Magiamgia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MAGIAMGI__25518C17");

            entity.HasOne(d => d.MakhNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Makh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MAKH__236943A5");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADON__MANV__245D67DE");
        });

        modelBuilder.Entity<Hoadonct>(entity =>
        {
            entity.HasKey(e => e.Mahdct).HasName("PK__HOADONCT__1A700082BC549E62");

            entity.ToTable("HOADONCT");

            entity.Property(e => e.Mahdct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAHDCT");
            entity.Property(e => e.Mahd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAHD");
            entity.Property(e => e.Maspct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASPCT");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MahdNavigation).WithMany(p => p.Hoadoncts)
                .HasForeignKey(d => d.Mahd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADONCT__MAHD__282DF8C2");

            entity.HasOne(d => d.MaspctNavigation).WithMany(p => p.Hoadoncts)
                .HasForeignKey(d => d.Maspct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HOADONCT__MASPCT__29221CFB");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makh).HasName("PK__KHACHHAN__603F592C6C33E491");

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.Makh)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAKH");
            entity.Property(e => e.Diachi).HasColumnName("DIACHI");
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

            entity.HasMany(d => d.Magiamgia).WithMany(p => p.Makhs)
                .UsingEntity<Dictionary<string, object>>(
                    "Khachhangvoucher",
                    r => r.HasOne<Voucher>().WithMany()
                        .HasForeignKey("Magiamgia")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_KHACHHANGVOUCHER_VOUCHER"),
                    l => l.HasOne<Khachhang>().WithMany()
                        .HasForeignKey("Makh")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_KHACHHANGVOUCHER_KHACHHANG"),
                    j =>
                    {
                        j.HasKey("Makh", "Magiamgia");
                        j.ToTable("KHACHHANGVOUCHER");
                        j.IndexerProperty<string>("Makh")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .HasColumnName("MAKH");
                        j.IndexerProperty<string>("Magiamgia")
                            .HasMaxLength(10)
                            .IsUnicode(false)
                            .HasColumnName("MAGIAMGIA");
                    });
        });

        modelBuilder.Entity<Loai>(entity =>
        {
            entity.HasKey(e => e.Maloai).HasName("PK__LOAI__2F633F23A1F0FFF5");

            entity.ToTable("LOAI");

            entity.Property(e => e.Maloai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MALOAI");
            entity.Property(e => e.Tenloai)
                .HasMaxLength(50)
                .HasColumnName("TENLOAI");
        });

        modelBuilder.Entity<Mau>(entity =>
        {
            entity.HasKey(e => e.Mamau).HasName("PK__MAU__7B7346CF71E376BB");

            entity.ToTable("MAU");

            entity.Property(e => e.Mamau)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAMAU");
            entity.Property(e => e.Mau1)
                .HasMaxLength(50)
                .HasColumnName("MAU");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Manv).HasName("PK__NHANVIEN__603F511490E3C095");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MANV");
            entity.Property(e => e.Diachi).HasColumnName("DIACHI");
            entity.Property(e => e.Email)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Gioitinh).HasColumnName("GIOITINH");
            entity.Property(e => e.Machucvu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MACHUCVU");
            entity.Property(e => e.Matkhau)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MATKHAU");
            entity.Property(e => e.Ngaysinh).HasColumnName("NGAYSINH");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Tenkhachhang)
                .HasMaxLength(50)
                .HasColumnName("TENKHACHHANG");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MachucvuNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Machucvu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NHANVIEN__MACHUC__778AC167");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Maorder).HasName("PK__ORDER__C8361541EDBF2273");

            entity.ToTable("ORDER");

            entity.Property(e => e.Maorder)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAORDER");
            entity.Property(e => e.Maghct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAGHCT");
            entity.Property(e => e.Manv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MANV");
            entity.Property(e => e.Ngaydat)
                .HasColumnType("datetime")
                .HasColumnName("NGAYDAT");
            entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaghctNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Maghct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ORDER__MAGHCT__1F98B2C1");

            entity.HasOne(d => d.ManvNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.Manv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ORDER__MANV__208CD6FA");
        });

        modelBuilder.Entity<Productdiscount>(entity =>
        {
            entity.HasKey(e => e.Madiscounts).HasName("PK__PRODUCTD__CC3E72D0C63B4F46");

            entity.ToTable("PRODUCTDISCOUNTS");

            entity.Property(e => e.Madiscounts)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MADISCOUNTS");
            entity.Property(e => e.Batdau)
                .HasColumnType("datetime")
                .HasColumnName("BATDAU");
            entity.Property(e => e.Discountsname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DISCOUNTSNAME");
            entity.Property(e => e.Ketthuc)
                .HasColumnType("datetime")
                .HasColumnName("KETTHUC");
            entity.Property(e => e.Maspct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASPCT");
            entity.Property(e => e.Phamtramgiam).HasColumnName("PHAMTRAMGIAM");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MaspctNavigation).WithMany(p => p.Productdiscounts)
                .HasForeignKey(d => d.Maspct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PRODUCTDI__MASPC__2EDAF651");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Masp).HasName("PK__SANPHAM__60228A32309B7F3D");

            entity.ToTable("SANPHAM");

            entity.Property(e => e.Masp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASP");
            entity.Property(e => e.Tensp)
                .HasMaxLength(50)
                .HasColumnName("TENSP");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");
        });

        modelBuilder.Entity<Sanphamct>(entity =>
        {
            entity.HasKey(e => e.Maspct).HasName("PK__SANPHAMC__3D158D86DA3BE69C");

            entity.ToTable("SANPHAMCT");

            entity.Property(e => e.Maspct)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASPCT");
            entity.Property(e => e.Gia).HasColumnName("GIA");
            entity.Property(e => e.Imgurl)
                .IsUnicode(false)
                .HasColumnName("IMGURL");
            entity.Property(e => e.Machatlieu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MACHATLIEU");
            entity.Property(e => e.Maloai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MALOAI");
            entity.Property(e => e.Mamau)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAMAU");
            entity.Property(e => e.Masize)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASIZE");
            entity.Property(e => e.Masp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASP");
            entity.Property(e => e.Mathuonghieu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MATHUONGHIEU");
            entity.Property(e => e.Maxuatxu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAXUATXU");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MachatlieuNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Machatlieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCT__MACHA__07C12930");

            entity.HasOne(d => d.MaloaiNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Maloai)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCT__MALOA__0C85DE4D");

            entity.HasOne(d => d.MamauNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Mamau)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCT__MAMAU__08B54D69");

            entity.HasOne(d => d.MasizeNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Masize)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCT__MASIZ__3A4CA8FD");

            entity.HasOne(d => d.MaspNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Masp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCT__MASP__09A971A2");

            entity.HasOne(d => d.MathuonghieuNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Mathuonghieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCT__MATHU__0B91BA14");

            entity.HasOne(d => d.MaxuatxuNavigation).WithMany(p => p.Sanphamcts)
                .HasForeignKey(d => d.Maxuatxu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SANPHAMCT__MAXUA__0A9D95DB");
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.Masize).HasName("PK__SIZE__3DD4402B638DA858");

            entity.ToTable("SIZE");

            entity.Property(e => e.Masize)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MASIZE");
            entity.Property(e => e.Size1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SIZE");
        });

        modelBuilder.Entity<Thanhtoan>(entity =>
        {
            entity.HasKey(e => e.Mathanhtoan).HasName("PK__THANHTOA__E5D8225C0FB93A6A");

            entity.ToTable("THANHTOAN");

            entity.Property(e => e.Mathanhtoan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MATHANHTOAN");
            entity.Property(e => e.Mahd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAHD");
            entity.Property(e => e.Ngaythanhtoan)
                .HasColumnType("datetime")
                .HasColumnName("NGAYTHANHTOAN");
            entity.Property(e => e.Phuongthuc)
                .HasMaxLength(50)
                .HasColumnName("PHUONGTHUC");
            entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MahdNavigation).WithMany(p => p.Thanhtoans)
                .HasForeignKey(d => d.Mahd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__THANHTOAN__MAHD__2BFE89A6");
        });

        modelBuilder.Entity<Thuonghieu>(entity =>
        {
            entity.HasKey(e => e.Mathuonghieu).HasName("PK__THUONGHI__B319F6385EF447F9");

            entity.ToTable("THUONGHIEU");

            entity.Property(e => e.Mathuonghieu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MATHUONGHIEU");
            entity.Property(e => e.Tenthuonghieu)
                .HasMaxLength(50)
                .HasColumnName("TENTHUONGHIEU");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.Magiamgia).HasName("PK__VOUCHER__41C28439EE4D6FBD");

            entity.ToTable("VOUCHER");

            entity.Property(e => e.Magiamgia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAGIAMGIA");
            entity.Property(e => e.Batdau)
                .HasColumnType("datetime")
                .HasColumnName("BATDAU");
            entity.Property(e => e.Ketthuc)
                .HasColumnType("datetime")
                .HasColumnName("KETTHUC");
            entity.Property(e => e.Phantramgiam).HasColumnName("PHANTRAMGIAM");
            entity.Property(e => e.Tenma)
                .HasMaxLength(50)
                .HasColumnName("TENMA");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(50)
                .HasColumnName("TRANGTHAI");
        });

        modelBuilder.Entity<Xuatxu>(entity =>
        {
            entity.HasKey(e => e.Maxuatxu).HasName("PK__XUATXU__52D93EA2D573971E");

            entity.ToTable("XUATXU");

            entity.Property(e => e.Maxuatxu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAXUATXU");
            entity.Property(e => e.Xuatxu1)
                .HasMaxLength(50)
                .HasColumnName("XUATXU");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
