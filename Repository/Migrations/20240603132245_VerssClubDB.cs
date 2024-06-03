using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class VerssClubDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHATLIEU",
                columns: table => new
                {
                    MACHATLIEU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENCHATLIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHATLIEU__80F939F8409953CD", x => x.MACHATLIEU);
                });

            migrationBuilder.CreateTable(
                name: "CHUCVU",
                columns: table => new
                {
                    MACHUCVU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VAITRO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHUCVU__9FA9FD6A30F1A097", x => x.MACHUCVU);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    MAKHACHHANG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENKHACHHANG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GIOITINH = table.Column<bool>(type: "bit", nullable: true),
                    SDT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    DIACHI = table.Column<string>(type: "text", nullable: true),
                    MATKHAU = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NGAYSINH = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHACHHAN__30035C2FBAF71AB2", x => x.MAKHACHHANG);
                });

            migrationBuilder.CreateTable(
                name: "LOAIMAU",
                columns: table => new
                {
                    MAMAU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENMAU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LOAIMAU__7B7346CFE972F6BC", x => x.MAMAU);
                });

            migrationBuilder.CreateTable(
                name: "LOAISANPHAM",
                columns: table => new
                {
                    MALOAISANPHAM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENLOAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LOAISANP__F22DB2996F257290", x => x.MALOAISANPHAM);
                });

            migrationBuilder.CreateTable(
                name: "SIZE",
                columns: table => new
                {
                    MASIZE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIZE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SIZE__3DD4402B59BB3D12", x => x.MASIZE);
                });

            migrationBuilder.CreateTable(
                name: "THUONGHIEU",
                columns: table => new
                {
                    MATHUONGHIEU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENTHUONGHIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__THUONGHI__B319F638DA1374F8", x => x.MATHUONGHIEU);
                });

            migrationBuilder.CreateTable(
                name: "VOUCHER",
                columns: table => new
                {
                    MAVOUCHER = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENVOUCHER = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NGAYTAO = table.Column<DateOnly>(type: "date", nullable: false),
                    NGAYBATDAU = table.Column<DateOnly>(type: "date", nullable: false),
                    NGAYKETTHUC = table.Column<DateOnly>(type: "date", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true),
                    PHANTRAMGIAM = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VOUCHER__56FC9ADE1ADA7F35", x => x.MAVOUCHER);
                });

            migrationBuilder.CreateTable(
                name: "XUATXU",
                columns: table => new
                {
                    MAXUATXU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DIADIEMXUATXU = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__XUATXU__52D93EA2009C47ED", x => x.MAXUATXU);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    MANHANVIEN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENNHANVIEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SDT = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    MATKHAU = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NAMSINH = table.Column<int>(type: "int", nullable: true),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: true),
                    MACHUCVU = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NHANVIEN__7E46DD91D3C3DD91", x => x.MANHANVIEN);
                    table.ForeignKey(
                        name: "FK_CHUCVU",
                        column: x => x.MACHUCVU,
                        principalTable: "CHUCVU",
                        principalColumn: "MACHUCVU");
                });

            migrationBuilder.CreateTable(
                name: "GIOHANG",
                columns: table => new
                {
                    MAGIOHANG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAKHACHHANG = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIOHANG__559F5534FE45FFEA", x => x.MAGIOHANG);
                    table.ForeignKey(
                        name: "FK__GIOHANG__MAKHACH__36B12243",
                        column: x => x.MAKHACHHANG,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKHACHHANG");
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG_VOUCHER",
                columns: table => new
                {
                    MAKHACHHANG = table.Column<int>(type: "int", nullable: false),
                    MAVOUCHER = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHACHHAN__C56C958289A8B217", x => new { x.MAKHACHHANG, x.MAVOUCHER });
                    table.ForeignKey(
                        name: "FK__KHACHHANG__MAKHA__3E52440B",
                        column: x => x.MAKHACHHANG,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKHACHHANG");
                    table.ForeignKey(
                        name: "FK__KHACHHANG__MAVOU__3F466844",
                        column: x => x.MAVOUCHER,
                        principalTable: "VOUCHER",
                        principalColumn: "MAVOUCHER");
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    MAHOADON = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAKHACHHANG = table.Column<int>(type: "int", nullable: false),
                    MAVOUCHER = table.Column<int>(type: "int", nullable: false),
                    MANHANVIEN = table.Column<int>(type: "int", nullable: false),
                    NGAYTAO = table.Column<DateOnly>(type: "date", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false),
                    GHICHU = table.Column<string>(type: "text", nullable: true),
                    TONGTIEN = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADON__A4999DF5A99DB3FF", x => x.MAHOADON);
                    table.ForeignKey(
                        name: "FK__HOADON__MANHANVI__4316F928",
                        column: x => x.MANHANVIEN,
                        principalTable: "NHANVIEN",
                        principalColumn: "MANHANVIEN");
                    table.ForeignKey(
                        name: "FK__HOADON__MAVOUCHE__440B1D61",
                        column: x => x.MAVOUCHER,
                        principalTable: "VOUCHER",
                        principalColumn: "MAVOUCHER");
                    table.ForeignKey(
                        name: "FK__HOADON__TONGTIEN__4222D4EF",
                        column: x => x.MAKHACHHANG,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKHACHHANG");
                });

            migrationBuilder.CreateTable(
                name: "GIOHANGCT",
                columns: table => new
                {
                    MAGIOHANGCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAKHACHHANG = table.Column<int>(type: "int", nullable: false),
                    MAGIOHANG = table.Column<int>(type: "int", nullable: false),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    TONGTIEN = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIOHANGC__9BEC54314D9966A1", x => x.MAGIOHANGCT);
                    table.ForeignKey(
                        name: "FK__GIOHANGCT__MAGIO__398D8EEE",
                        column: x => x.MAGIOHANG,
                        principalTable: "GIOHANG",
                        principalColumn: "MAGIOHANG");
                });

            migrationBuilder.CreateTable(
                name: "THANHTOAN",
                columns: table => new
                {
                    MATHANHTOAN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAHOADON = table.Column<int>(type: "int", nullable: false),
                    PHUONGTHUCTHANHTOAN = table.Column<int>(type: "int", nullable: false),
                    NGAYTHANHTOAN = table.Column<DateOnly>(type: "date", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false),
                    TONGTIEN = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__THANHTOA__E5D8225C7887F3AC", x => x.MATHANHTOAN);
                    table.ForeignKey(
                        name: "FK__THANHTOAN__TONGT__46E78A0C",
                        column: x => x.MAHOADON,
                        principalTable: "HOADON",
                        principalColumn: "MAHOADON");
                });

            migrationBuilder.CreateTable(
                name: "ORDER",
                columns: table => new
                {
                    MAORDER = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAGIOHANGCT = table.Column<int>(type: "int", nullable: false),
                    MANHANVIEN = table.Column<int>(type: "int", nullable: false),
                    NGAYDATHANG = table.Column<DateOnly>(type: "date", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ORDER__C836154144ACBD5A", x => x.MAORDER);
                    table.ForeignKey(
                        name: "FK__ORDER__MAGIOHANG__60A75C0F",
                        column: x => x.MAGIOHANGCT,
                        principalTable: "GIOHANGCT",
                        principalColumn: "MAGIOHANGCT");
                    table.ForeignKey(
                        name: "FK__ORDER__MANHANVIE__5FB337D6",
                        column: x => x.MANHANVIEN,
                        principalTable: "NHANVIEN",
                        principalColumn: "MANHANVIEN");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    MASANPHAM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAGIOHANGCT = table.Column<int>(type: "int", nullable: false),
                    TENSANPHAM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MACHATLIEU = table.Column<int>(type: "int", nullable: false),
                    MAXUATXU = table.Column<int>(type: "int", nullable: false),
                    MATHUONGHIEU = table.Column<int>(type: "int", nullable: false),
                    MALOAISANPHAM = table.Column<int>(type: "int", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAM__9534C89206358B7F", x => x.MASANPHAM);
                    table.ForeignKey(
                        name: "FK__SANPHAM__MACHATL__4AB81AF0",
                        column: x => x.MACHATLIEU,
                        principalTable: "CHATLIEU",
                        principalColumn: "MACHATLIEU");
                    table.ForeignKey(
                        name: "FK__SANPHAM__MAGIOHA__49C3F6B7",
                        column: x => x.MAGIOHANGCT,
                        principalTable: "GIOHANGCT",
                        principalColumn: "MAGIOHANGCT");
                    table.ForeignKey(
                        name: "FK__SANPHAM__MALOAIS__4D94879B",
                        column: x => x.MALOAISANPHAM,
                        principalTable: "LOAISANPHAM",
                        principalColumn: "MALOAISANPHAM");
                    table.ForeignKey(
                        name: "FK__SANPHAM__MATHUON__4CA06362",
                        column: x => x.MATHUONGHIEU,
                        principalTable: "THUONGHIEU",
                        principalColumn: "MATHUONGHIEU");
                    table.ForeignKey(
                        name: "FK__SANPHAM__MAXUATX__4BAC3F29",
                        column: x => x.MAXUATXU,
                        principalTable: "XUATXU",
                        principalColumn: "MAXUATXU");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAMCT",
                columns: table => new
                {
                    MASANPHAMCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENSANPHAMCT = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MACHATLIEU = table.Column<int>(type: "int", nullable: false),
                    MAMAU = table.Column<int>(type: "int", nullable: false),
                    MASANPHAM = table.Column<int>(type: "int", nullable: false),
                    MAXUATXU = table.Column<int>(type: "int", nullable: false),
                    MATHUONGHIEU = table.Column<int>(type: "int", nullable: false),
                    MALOAISANPHAM = table.Column<int>(type: "int", nullable: false),
                    MASIZE = table.Column<int>(type: "int", nullable: false),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false),
                    IMGURL = table.Column<string>(type: "text", nullable: false),
                    GIA = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAMC__E932BBBC8E57A655", x => x.MASANPHAMCT);
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MACHA__5070F446",
                        column: x => x.MACHATLIEU,
                        principalTable: "CHATLIEU",
                        principalColumn: "MACHATLIEU");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MALOA__5535A963",
                        column: x => x.MALOAISANPHAM,
                        principalTable: "LOAISANPHAM",
                        principalColumn: "MALOAISANPHAM");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MAMAU__5165187F",
                        column: x => x.MAMAU,
                        principalTable: "LOAIMAU",
                        principalColumn: "MAMAU");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MASAN__52593CB8",
                        column: x => x.MASANPHAM,
                        principalTable: "SANPHAM",
                        principalColumn: "MASANPHAM");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MASIZ__5629CD9C",
                        column: x => x.MASIZE,
                        principalTable: "SIZE",
                        principalColumn: "MASIZE");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MATHU__5441852A",
                        column: x => x.MATHUONGHIEU,
                        principalTable: "VOUCHER",
                        principalColumn: "MAVOUCHER");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MAXUA__534D60F1",
                        column: x => x.MAXUATXU,
                        principalTable: "XUATXU",
                        principalColumn: "MAXUATXU");
                });

            migrationBuilder.CreateTable(
                name: "DANHGIA",
                columns: table => new
                {
                    MADANHGIA = table.Column<int>(type: "int", nullable: false),
                    MASANPHAMCT = table.Column<int>(type: "int", nullable: true),
                    MAKHACHHANG = table.Column<int>(type: "int", nullable: true),
                    MOTA = table.Column<string>(type: "text", nullable: true),
                    HINHANH = table.Column<string>(type: "text", nullable: true),
                    NGAYDANG = table.Column<DateOnly>(type: "date", nullable: true),
                    SOSAO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DANHGIA__8597D60A5B123A9C", x => x.MADANHGIA);
                    table.ForeignKey(
                        name: "FK__DANHGIA__MAKHACH__6477ECF3",
                        column: x => x.MAKHACHHANG,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKHACHHANG");
                    table.ForeignKey(
                        name: "FK__DANHGIA__MASANPH__6383C8BA",
                        column: x => x.MASANPHAMCT,
                        principalTable: "SANPHAMCT",
                        principalColumn: "MASANPHAMCT");
                });

            migrationBuilder.CreateTable(
                name: "GIAMGIA",
                columns: table => new
                {
                    MAGIAMGIA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENGIAMGIA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MASANPHAMCT = table.Column<int>(type: "int", nullable: false),
                    NGAYTAO = table.Column<DateTime>(type: "datetime", nullable: false),
                    NGAYBATDAU = table.Column<DateOnly>(type: "date", nullable: false),
                    NGAYKETTHUC = table.Column<DateOnly>(type: "date", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false),
                    TILEGIAMGIA = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIAMGIA__41C28439E7F89EE5", x => x.MAGIAMGIA);
                    table.ForeignKey(
                        name: "FK__GIAMGIA__MASANPH__59063A47",
                        column: x => x.MASANPHAMCT,
                        principalTable: "SANPHAMCT",
                        principalColumn: "MASANPHAMCT");
                });

            migrationBuilder.CreateTable(
                name: "HOADONCT",
                columns: table => new
                {
                    MAHOADONCT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAHOADON = table.Column<int>(type: "int", nullable: false),
                    MASANPHAMCT = table.Column<int>(type: "int", nullable: false),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    TONGTIEN = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    TRANGTHAI = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADONCT__658D76744B544D7F", x => x.MAHOADONCT);
                    table.ForeignKey(
                        name: "FK__HOADONCT__MAHOAD__5BE2A6F2",
                        column: x => x.MAHOADON,
                        principalTable: "HOADON",
                        principalColumn: "MAHOADON");
                    table.ForeignKey(
                        name: "FK__HOADONCT__MASANP__5CD6CB2B",
                        column: x => x.MASANPHAMCT,
                        principalTable: "SANPHAMCT",
                        principalColumn: "MASANPHAMCT");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DANHGIA_MAKHACHHANG",
                table: "DANHGIA",
                column: "MAKHACHHANG");

            migrationBuilder.CreateIndex(
                name: "IX_DANHGIA_MASANPHAMCT",
                table: "DANHGIA",
                column: "MASANPHAMCT");

            migrationBuilder.CreateIndex(
                name: "IX_GIAMGIA_MASANPHAMCT",
                table: "GIAMGIA",
                column: "MASANPHAMCT");

            migrationBuilder.CreateIndex(
                name: "IX_GIOHANG_MAKHACHHANG",
                table: "GIOHANG",
                column: "MAKHACHHANG");

            migrationBuilder.CreateIndex(
                name: "IX_GIOHANGCT_MAGIOHANG",
                table: "GIOHANGCT",
                column: "MAGIOHANG");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MAKHACHHANG",
                table: "HOADON",
                column: "MAKHACHHANG");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MANHANVIEN",
                table: "HOADON",
                column: "MANHANVIEN");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MAVOUCHER",
                table: "HOADON",
                column: "MAVOUCHER");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCT_MAHOADON",
                table: "HOADONCT",
                column: "MAHOADON");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCT_MASANPHAMCT",
                table: "HOADONCT",
                column: "MASANPHAMCT");

            migrationBuilder.CreateIndex(
                name: "IX_KHACHHANG_VOUCHER_MAVOUCHER",
                table: "KHACHHANG_VOUCHER",
                column: "MAVOUCHER");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_MACHUCVU",
                table: "NHANVIEN",
                column: "MACHUCVU");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_MAGIOHANGCT",
                table: "ORDER",
                column: "MAGIOHANGCT");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_MANHANVIEN",
                table: "ORDER",
                column: "MANHANVIEN");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MACHATLIEU",
                table: "SANPHAM",
                column: "MACHATLIEU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MAGIOHANGCT",
                table: "SANPHAM",
                column: "MAGIOHANGCT");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MALOAISANPHAM",
                table: "SANPHAM",
                column: "MALOAISANPHAM");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MATHUONGHIEU",
                table: "SANPHAM",
                column: "MATHUONGHIEU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MAXUATXU",
                table: "SANPHAM",
                column: "MAXUATXU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MACHATLIEU",
                table: "SANPHAMCT",
                column: "MACHATLIEU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MALOAISANPHAM",
                table: "SANPHAMCT",
                column: "MALOAISANPHAM");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MAMAU",
                table: "SANPHAMCT",
                column: "MAMAU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MASANPHAM",
                table: "SANPHAMCT",
                column: "MASANPHAM");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MASIZE",
                table: "SANPHAMCT",
                column: "MASIZE");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MATHUONGHIEU",
                table: "SANPHAMCT",
                column: "MATHUONGHIEU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MAXUATXU",
                table: "SANPHAMCT",
                column: "MAXUATXU");

            migrationBuilder.CreateIndex(
                name: "IX_THANHTOAN_MAHOADON",
                table: "THANHTOAN",
                column: "MAHOADON");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DANHGIA");

            migrationBuilder.DropTable(
                name: "GIAMGIA");

            migrationBuilder.DropTable(
                name: "HOADONCT");

            migrationBuilder.DropTable(
                name: "KHACHHANG_VOUCHER");

            migrationBuilder.DropTable(
                name: "ORDER");

            migrationBuilder.DropTable(
                name: "THANHTOAN");

            migrationBuilder.DropTable(
                name: "SANPHAMCT");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "LOAIMAU");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "SIZE");

            migrationBuilder.DropTable(
                name: "NHANVIEN");

            migrationBuilder.DropTable(
                name: "VOUCHER");

            migrationBuilder.DropTable(
                name: "CHATLIEU");

            migrationBuilder.DropTable(
                name: "GIOHANGCT");

            migrationBuilder.DropTable(
                name: "LOAISANPHAM");

            migrationBuilder.DropTable(
                name: "THUONGHIEU");

            migrationBuilder.DropTable(
                name: "XUATXU");

            migrationBuilder.DropTable(
                name: "CHUCVU");

            migrationBuilder.DropTable(
                name: "GIOHANG");

            migrationBuilder.DropTable(
                name: "KHACHHANG");
        }
    }
}
