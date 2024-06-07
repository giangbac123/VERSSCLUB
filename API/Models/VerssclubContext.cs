using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using API.Models;
namespace API.Models
{
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

        public virtual DbSet<Giamgium> Giamgia { get; set; }

        public virtual DbSet<Giohang> Giohangs { get; set; }

        public virtual DbSet<Giohangct> Giohangcts { get; set; }

        public virtual DbSet<Hoadon> Hoadons { get; set; }

        public virtual DbSet<Hoadonct> Hoadoncts { get; set; }

        public virtual DbSet<Khachhang> Khachhangs { get; set; }

        public virtual DbSet<Loaimau> Loaimaus { get; set; }

        public virtual DbSet<Loaisanpham> Loaisanphams { get; set; }

        public virtual DbSet<Nhanvien> Nhanviens { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

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
                entity.HasKey(e => e.Machatlieu).HasName("PK__CHATLIEU__80F939F8409953CD");

                entity.ToTable("CHATLIEU");

                entity.Property(e => e.Machatlieu).HasColumnName("MACHATLIEU");
                entity.Property(e => e.Tenchatlieu)
                    .HasMaxLength(50)
                    .HasColumnName("TENCHATLIEU");
            });

            modelBuilder.Entity<Chucvu>(entity =>
            {
                entity.HasKey(e => e.Machucvu).HasName("PK__CHUCVU__9FA9FD6A30F1A097");

                entity.ToTable("CHUCVU");

                entity.Property(e => e.Machucvu).HasColumnName("MACHUCVU");
                entity.Property(e => e.Vaitro)
                    .HasMaxLength(50)
                    .HasColumnName("VAITRO");
            });

            modelBuilder.Entity<Danhgium>(entity =>
            {
                entity.HasKey(e => e.Madanhgia).HasName("PK__DANHGIA__8597D60A5B123A9C");

                entity.ToTable("DANHGIA");

                entity.Property(e => e.Madanhgia)
                    .ValueGeneratedNever()
                    .HasColumnName("MADANHGIA");
                entity.Property(e => e.Hinhanh)
                    .HasColumnType("text")
                    .HasColumnName("HINHANH");
                entity.Property(e => e.Makhachhang).HasColumnName("MAKHACHHANG");
                entity.Property(e => e.Masanphamct).HasColumnName("MASANPHAMCT");
                entity.Property(e => e.Mota)
                    .HasColumnType("text")
                    .HasColumnName("MOTA");
                entity.Property(e => e.Ngaydang).HasColumnName("NGAYDANG");
                entity.Property(e => e.Sosao).HasColumnName("SOSAO");

                entity.HasOne(d => d.MakhachhangNavigation).WithMany(p => p.Danhgia)
                    .HasForeignKey(d => d.Makhachhang)
                    .HasConstraintName("FK__DANHGIA__MAKHACH__6477ECF3");

                entity.HasOne(d => d.MasanphamctNavigation).WithMany(p => p.Danhgia)
                    .HasForeignKey(d => d.Masanphamct)
                    .HasConstraintName("FK__DANHGIA__MASANPH__6383C8BA");
            });

            modelBuilder.Entity<Giamgium>(entity =>
            {
                entity.HasKey(e => e.Magiamgia).HasName("PK__GIAMGIA__41C28439E7F89EE5");

                entity.ToTable("GIAMGIA");

                entity.Property(e => e.Magiamgia).HasColumnName("MAGIAMGIA");
                entity.Property(e => e.Masanphamct).HasColumnName("MASANPHAMCT");
                entity.Property(e => e.Ngaybatdau).HasColumnName("NGAYBATDAU");
                entity.Property(e => e.Ngayketthuc).HasColumnName("NGAYKETTHUC");
                entity.Property(e => e.Ngaytao)
                    .HasColumnType("datetime")
                    .HasColumnName("NGAYTAO");
                entity.Property(e => e.Tengiamgia)
                    .HasMaxLength(50)
                    .HasColumnName("TENGIAMGIA");
                entity.Property(e => e.Tilegiamgia).HasColumnName("TILEGIAMGIA");
                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.MasanphamctNavigation).WithMany(p => p.Giamgia)
                    .HasForeignKey(d => d.Masanphamct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GIAMGIA__MASANPH__59063A47");
            });

            modelBuilder.Entity<Giohang>(entity =>
            {
                entity.HasKey(e => e.Magiohang).HasName("PK__GIOHANG__559F5534FE45FFEA");

                entity.ToTable("GIOHANG");

                entity.Property(e => e.Magiohang).HasColumnName("MAGIOHANG");
                entity.Property(e => e.Makhachhang).HasColumnName("MAKHACHHANG");

                entity.HasOne(d => d.MakhachhangNavigation).WithMany(p => p.Giohangs)
                    .HasForeignKey(d => d.Makhachhang)
                    .HasConstraintName("FK__GIOHANG__MAKHACH__36B12243");
            });

            modelBuilder.Entity<Giohangct>(entity =>
            {
                entity.HasKey(e => e.Magiohangct).HasName("PK__GIOHANGC__9BEC54314D9966A1");

                entity.ToTable("GIOHANGCT");

                entity.Property(e => e.Magiohangct).HasColumnName("MAGIOHANGCT");
                entity.Property(e => e.Magiohang).HasColumnName("MAGIOHANG");
                entity.Property(e => e.Makhachhang).HasColumnName("MAKHACHHANG");
                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
                entity.Property(e => e.Tongtien)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TONGTIEN");

                entity.HasOne(d => d.MagiohangNavigation).WithMany(p => p.Giohangcts)
                    .HasForeignKey(d => d.Magiohang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GIOHANGCT__MAGIO__398D8EEE");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.HasKey(e => e.Mahoadon).HasName("PK__HOADON__A4999DF5A99DB3FF");

                entity.ToTable("HOADON");

                entity.Property(e => e.Mahoadon).HasColumnName("MAHOADON");
                entity.Property(e => e.Ghichu)
                    .HasColumnType("text")
                    .HasColumnName("GHICHU");
                entity.Property(e => e.Makhachhang).HasColumnName("MAKHACHHANG");
                entity.Property(e => e.Manhanvien).HasColumnName("MANHANVIEN");
                entity.Property(e => e.Mavoucher).HasColumnName("MAVOUCHER");
                entity.Property(e => e.Ngaytao).HasColumnName("NGAYTAO");
                entity.Property(e => e.Tongtien)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TONGTIEN");
                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.MakhachhangNavigation).WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Makhachhang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADON__TONGTIEN__4222D4EF");

                entity.HasOne(d => d.ManhanvienNavigation).WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Manhanvien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADON__MANHANVI__4316F928");

                entity.HasOne(d => d.MavoucherNavigation).WithMany(p => p.Hoadons)
                    .HasForeignKey(d => d.Mavoucher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADON__MAVOUCHE__440B1D61");
            });

            modelBuilder.Entity<Hoadonct>(entity =>
            {
                entity.HasKey(e => e.Mahoadonct).HasName("PK__HOADONCT__658D76744B544D7F");

                entity.ToTable("HOADONCT");

                entity.Property(e => e.Mahoadonct).HasColumnName("MAHOADONCT");
                entity.Property(e => e.Mahoadon).HasColumnName("MAHOADON");
                entity.Property(e => e.Masanphamct).HasColumnName("MASANPHAMCT");
                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
                entity.Property(e => e.Tongtien)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TONGTIEN");
                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.MahoadonNavigation).WithMany(p => p.Hoadoncts)
                    .HasForeignKey(d => d.Mahoadon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADONCT__MAHOAD__5BE2A6F2");

                entity.HasOne(d => d.MasanphamctNavigation).WithMany(p => p.Hoadoncts)
                    .HasForeignKey(d => d.Masanphamct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HOADONCT__MASANP__5CD6CB2B");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.Makhachhang).HasName("PK__KHACHHAN__30035C2FBAF71AB2");

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.Makhachhang).HasColumnName("MAKHACHHANG");
                entity.Property(e => e.Diachi)
                    .HasColumnType("text")
                    .HasColumnName("DIACHI");
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");
                entity.Property(e => e.Gioitinh).HasColumnName("GIOITINH");
                entity.Property(e => e.Matkhau)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MATKHAU");
                entity.Property(e => e.Ngaysinh).HasColumnName("NGAYSINH");
                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDT");
                entity.Property(e => e.Tenkhachhang)
                    .HasMaxLength(50)
                    .HasColumnName("TENKHACHHANG");

                entity.HasMany(d => d.Mavouchers).WithMany(p => p.Makhachhangs)
                    .UsingEntity<Dictionary<string, object>>(
                        "KhachhangVoucher",
                        r => r.HasOne<Voucher>().WithMany()
                            .HasForeignKey("Mavoucher")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__KHACHHANG__MAVOU__3F466844"),
                        l => l.HasOne<Khachhang>().WithMany()
                            .HasForeignKey("Makhachhang")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK__KHACHHANG__MAKHA__3E52440B"),
                        j =>
                        {
                            j.HasKey("Makhachhang", "Mavoucher").HasName("PK__KHACHHAN__C56C958289A8B217");
                            j.ToTable("KHACHHANG_VOUCHER");
                            j.IndexerProperty<int>("Makhachhang").HasColumnName("MAKHACHHANG");
                            j.IndexerProperty<int>("Mavoucher").HasColumnName("MAVOUCHER");
                        });
            });

            modelBuilder.Entity<Loaimau>(entity =>
            {
                entity.HasKey(e => e.Mamau).HasName("PK__LOAIMAU__7B7346CFE972F6BC");

                entity.ToTable("LOAIMAU");

                entity.Property(e => e.Mamau).HasColumnName("MAMAU");
                entity.Property(e => e.Tenmau)
                    .HasMaxLength(50)
                    .HasColumnName("TENMAU");
            });

            modelBuilder.Entity<Loaisanpham>(entity =>
            {
                entity.HasKey(e => e.Maloaisanpham).HasName("PK__LOAISANP__F22DB2996F257290");

                entity.ToTable("LOAISANPHAM");

                entity.Property(e => e.Maloaisanpham).HasColumnName("MALOAISANPHAM");
                entity.Property(e => e.Tenloai)
                    .HasMaxLength(50)
                    .HasColumnName("TENLOAI");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manhanvien).HasName("PK__NHANVIEN__7E46DD91D3C3DD91");

                entity.ToTable("NHANVIEN");

                entity.Property(e => e.Manhanvien).HasColumnName("MANHANVIEN");
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");
                entity.Property(e => e.Machucvu).HasColumnName("MACHUCVU");
                entity.Property(e => e.Matkhau)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MATKHAU");
                entity.Property(e => e.Namsinh).HasColumnName("NAMSINH");
                entity.Property(e => e.Sdt)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SDT");
                entity.Property(e => e.Tennhanvien)
                    .HasMaxLength(50)
                    .HasColumnName("TENNHANVIEN");
                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.MachucvuNavigation).WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => d.Machucvu)
                    .HasConstraintName("FK_CHUCVU");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Maorder).HasName("PK__ORDER__C836154144ACBD5A");

                entity.ToTable("ORDER");

                entity.Property(e => e.Maorder).HasColumnName("MAORDER");
                entity.Property(e => e.Magiohangct).HasColumnName("MAGIOHANGCT");
                entity.Property(e => e.Manhanvien).HasColumnName("MANHANVIEN");
                entity.Property(e => e.Ngaydathang).HasColumnName("NGAYDATHANG");
                entity.Property(e => e.TongTien).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MagiohangctNavigation).WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Magiohangct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ORDER__MAGIOHANG__60A75C0F");

                entity.HasOne(d => d.ManhanvienNavigation).WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Manhanvien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ORDER__MANHANVIE__5FB337D6");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.Masanpham).HasName("PK__SANPHAM__9534C89206358B7F");

                entity.ToTable("SANPHAM");

                entity.Property(e => e.Masanpham).HasColumnName("MASANPHAM");
                entity.Property(e => e.Machatlieu).HasColumnName("MACHATLIEU");
                entity.Property(e => e.Magiohangct).HasColumnName("MAGIOHANGCT");
                entity.Property(e => e.Maloaisanpham).HasColumnName("MALOAISANPHAM");
                entity.Property(e => e.Mathuonghieu).HasColumnName("MATHUONGHIEU");
                entity.Property(e => e.Maxuatxu).HasColumnName("MAXUATXU");
                entity.Property(e => e.Tensanpham)
                    .HasMaxLength(50)
                    .HasColumnName("TENSANPHAM");
                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.MachatlieuNavigation).WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.Machatlieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAM__MACHATL__4AB81AF0");

                entity.HasOne(d => d.MagiohangctNavigation).WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.Magiohangct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAM__MAGIOHA__49C3F6B7");

                entity.HasOne(d => d.MaloaisanphamNavigation).WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.Maloaisanpham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAM__MALOAIS__4D94879B");

                entity.HasOne(d => d.MathuonghieuNavigation).WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.Mathuonghieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAM__MATHUON__4CA06362");

                entity.HasOne(d => d.MaxuatxuNavigation).WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.Maxuatxu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAM__MAXUATX__4BAC3F29");
            });

            modelBuilder.Entity<Sanphamct>(entity =>
            {
                entity.HasKey(e => e.Masanphamct).HasName("PK__SANPHAMC__E932BBBC8E57A655");

                entity.ToTable("SANPHAMCT");

                entity.Property(e => e.Masanphamct).HasColumnName("MASANPHAMCT");
                entity.Property(e => e.Gia)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GIA");
                entity.Property(e => e.Imgurl)
                    .HasColumnType("text")
                    .HasColumnName("IMGURL");
                entity.Property(e => e.Machatlieu).HasColumnName("MACHATLIEU");
                entity.Property(e => e.Maloaisanpham).HasColumnName("MALOAISANPHAM");
                entity.Property(e => e.Mamau).HasColumnName("MAMAU");
                entity.Property(e => e.Masanpham).HasColumnName("MASANPHAM");
                entity.Property(e => e.Masize).HasColumnName("MASIZE");
                entity.Property(e => e.Mathuonghieu).HasColumnName("MATHUONGHIEU");
                entity.Property(e => e.Maxuatxu).HasColumnName("MAXUATXU");
                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
                entity.Property(e => e.Tensanphamct)
                    .HasMaxLength(50)
                    .HasColumnName("TENSANPHAMCT");
                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.MachatlieuNavigation).WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.Machatlieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCT__MACHA__5070F446");

                entity.HasOne(d => d.MaloaisanphamNavigation).WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.Maloaisanpham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCT__MALOA__5535A963");

                entity.HasOne(d => d.MamauNavigation).WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.Mamau)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCT__MAMAU__5165187F");

                entity.HasOne(d => d.MasanphamNavigation).WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.Masanpham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCT__MASAN__52593CB8");

                entity.HasOne(d => d.MasizeNavigation).WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.Masize)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCT__MASIZ__5629CD9C");

                entity.HasOne(d => d.MathuonghieuNavigation).WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.Mathuonghieu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCT__MATHU__5441852A");

                entity.HasOne(d => d.MaxuatxuNavigation).WithMany(p => p.Sanphamcts)
                    .HasForeignKey(d => d.Maxuatxu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SANPHAMCT__MAXUA__534D60F1");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.HasKey(e => e.Masize).HasName("PK__SIZE__3DD4402B59BB3D12");

                entity.ToTable("SIZE");

                entity.Property(e => e.Masize).HasColumnName("MASIZE");
                entity.Property(e => e.Size1).HasColumnName("SIZE");
            });

            modelBuilder.Entity<Thanhtoan>(entity =>
            {
                entity.HasKey(e => e.Mathanhtoan).HasName("PK__THANHTOA__E5D8225C7887F3AC");

                entity.ToTable("THANHTOAN");

                entity.Property(e => e.Mathanhtoan).HasColumnName("MATHANHTOAN");
                entity.Property(e => e.Mahoadon).HasColumnName("MAHOADON");
                entity.Property(e => e.Ngaythanhtoan).HasColumnName("NGAYTHANHTOAN");
                entity.Property(e => e.Phuongthucthanhtoan).HasColumnName("PHUONGTHUCTHANHTOAN");
                entity.Property(e => e.Tongtien)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TONGTIEN");
                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.MahoadonNavigation).WithMany(p => p.Thanhtoans)
                    .HasForeignKey(d => d.Mahoadon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__THANHTOAN__TONGT__46E78A0C");
            });

            modelBuilder.Entity<Thuonghieu>(entity =>
            {
                entity.HasKey(e => e.Mathuonghieu).HasName("PK__THUONGHI__B319F638DA1374F8");

                entity.ToTable("THUONGHIEU");

                entity.Property(e => e.Mathuonghieu).HasColumnName("MATHUONGHIEU");
                entity.Property(e => e.Tenthuonghieu)
                    .HasMaxLength(50)
                    .HasColumnName("TENTHUONGHIEU");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.Mavoucher).HasName("PK__VOUCHER__56FC9ADE1ADA7F35");

                entity.ToTable("VOUCHER");

                entity.Property(e => e.Mavoucher).HasColumnName("MAVOUCHER");
                entity.Property(e => e.Ngaybatdau).HasColumnName("NGAYBATDAU");
                entity.Property(e => e.Ngayketthuc).HasColumnName("NGAYKETTHUC");
                entity.Property(e => e.Ngaytao).HasColumnName("NGAYTAO");
                entity.Property(e => e.Phantramgiam).HasColumnName("PHANTRAMGIAM");
                entity.Property(e => e.Tenvoucher)
                    .HasMaxLength(100)
                    .HasColumnName("TENVOUCHER");
                entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
            });

            modelBuilder.Entity<Xuatxu>(entity =>
            {
                entity.HasKey(e => e.Maxuatxu).HasName("PK__XUATXU__52D93EA2009C47ED");

                entity.ToTable("XUATXU");

                entity.Property(e => e.Maxuatxu).HasColumnName("MAXUATXU");
                entity.Property(e => e.Diadiemxuatxu)
                    .HasColumnType("text")
                    .HasColumnName("DIADIEMXUATXU");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}

