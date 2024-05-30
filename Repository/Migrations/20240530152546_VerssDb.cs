using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class VerssDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHATLIEU",
                columns: table => new
                {
                    MACHATLIEU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TENCHATLIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHATLIEU__80F939F813A47416", x => x.MACHATLIEU);
                });

            migrationBuilder.CreateTable(
                name: "CHUCVU",
                columns: table => new
                {
                    MACHUCVU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    VAITRO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHUCVU__9FA9FD6A7CBD95BE", x => x.MACHUCVU);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    MAKH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    HOTEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GIOITINH = table.Column<bool>(type: "bit", nullable: false),
                    SDT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DIACHI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MATKHAU = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    NGAYSINH = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHACHHAN__603F592C6C33E491", x => x.MAKH);
                });

            migrationBuilder.CreateTable(
                name: "LOAI",
                columns: table => new
                {
                    MALOAI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TENLOAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LOAI__2F633F23A1F0FFF5", x => x.MALOAI);
                });

            migrationBuilder.CreateTable(
                name: "MAU",
                columns: table => new
                {
                    MAMAU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MAU__7B7346CF71E376BB", x => x.MAMAU);
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    MASP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TENSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAM__60228A32309B7F3D", x => x.MASP);
                });

            migrationBuilder.CreateTable(
                name: "SIZE",
                columns: table => new
                {
                    MASIZE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SIZE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SIZE__3DD4402B638DA858", x => x.MASIZE);
                });

            migrationBuilder.CreateTable(
                name: "THUONGHIEU",
                columns: table => new
                {
                    MATHUONGHIEU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TENTHUONGHIEU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__THUONGHI__B319F6385EF447F9", x => x.MATHUONGHIEU);
                });

            migrationBuilder.CreateTable(
                name: "VOUCHER",
                columns: table => new
                {
                    MAGIAMGIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TENMA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BATDAU = table.Column<DateTime>(type: "datetime", nullable: false),
                    KETTHUC = table.Column<DateTime>(type: "datetime", nullable: false),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PHANTRAMGIAM = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__VOUCHER__41C28439EE4D6FBD", x => x.MAGIAMGIA);
                });

            migrationBuilder.CreateTable(
                name: "XUATXU",
                columns: table => new
                {
                    MAXUATXU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    XUATXU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__XUATXU__52D93EA2D573971E", x => x.MAXUATXU);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    MANV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TENKHACHHANG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GIOITINH = table.Column<bool>(type: "bit", nullable: false),
                    SDT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DIACHI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MATKHAU = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    NGAYSINH = table.Column<DateOnly>(type: "date", nullable: false),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MACHUCVU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NHANVIEN__603F511490E3C095", x => x.MANV);
                    table.ForeignKey(
                        name: "FK__NHANVIEN__MACHUC__778AC167",
                        column: x => x.MACHUCVU,
                        principalTable: "CHUCVU",
                        principalColumn: "MACHUCVU");
                });

            migrationBuilder.CreateTable(
                name: "GIOHANG",
                columns: table => new
                {
                    MAKH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIOHANG__603F592CB7F9DAF2", x => x.MAKH);
                    table.ForeignKey(
                        name: "FK_GIOHANG_KHACHHANG",
                        column: x => x.MAKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKH");
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANGVOUCHER",
                columns: table => new
                {
                    MAKH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAGIAMGIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHACHHANGVOUCHER", x => new { x.MAKH, x.MAGIAMGIA });
                    table.ForeignKey(
                        name: "FK_KHACHHANGVOUCHER_KHACHHANG",
                        column: x => x.MAKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKH");
                    table.ForeignKey(
                        name: "FK_KHACHHANGVOUCHER_VOUCHER",
                        column: x => x.MAGIAMGIA,
                        principalTable: "VOUCHER",
                        principalColumn: "MAGIAMGIA");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAMCT",
                columns: table => new
                {
                    MASPCT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    GIA = table.Column<double>(type: "float", nullable: false),
                    MACHATLIEU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAMAU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IMGURL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    MASP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAXUATXU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MATHUONGHIEU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MALOAI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MASIZE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAMC__3D158D86DA3BE69C", x => x.MASPCT);
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MACHA__07C12930",
                        column: x => x.MACHATLIEU,
                        principalTable: "CHATLIEU",
                        principalColumn: "MACHATLIEU");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MALOA__0C85DE4D",
                        column: x => x.MALOAI,
                        principalTable: "LOAI",
                        principalColumn: "MALOAI");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MAMAU__08B54D69",
                        column: x => x.MAMAU,
                        principalTable: "MAU",
                        principalColumn: "MAMAU");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MASIZ__3A4CA8FD",
                        column: x => x.MASIZE,
                        principalTable: "SIZE",
                        principalColumn: "MASIZE");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MASP__09A971A2",
                        column: x => x.MASP,
                        principalTable: "SANPHAM",
                        principalColumn: "MASP");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MATHU__0B91BA14",
                        column: x => x.MATHUONGHIEU,
                        principalTable: "THUONGHIEU",
                        principalColumn: "MATHUONGHIEU");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MAXUA__0A9D95DB",
                        column: x => x.MAXUATXU,
                        principalTable: "XUATXU",
                        principalColumn: "MAXUATXU");
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    MAHD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAKH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MANV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAGIAMGIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    GHICHU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TONGTIEN = table.Column<double>(type: "float", nullable: false),
                    NGAYTAO = table.Column<DateTime>(type: "datetime", nullable: false),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADON__603F20CE82D3DF24", x => x.MAHD);
                    table.ForeignKey(
                        name: "FK__HOADON__MAGIAMGI__25518C17",
                        column: x => x.MAGIAMGIA,
                        principalTable: "VOUCHER",
                        principalColumn: "MAGIAMGIA");
                    table.ForeignKey(
                        name: "FK__HOADON__MAKH__236943A5",
                        column: x => x.MAKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKH");
                    table.ForeignKey(
                        name: "FK__HOADON__MANV__245D67DE",
                        column: x => x.MANV,
                        principalTable: "NHANVIEN",
                        principalColumn: "MANV");
                });

            migrationBuilder.CreateTable(
                name: "DANHGIA",
                columns: table => new
                {
                    MADANHGIA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAKH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MASPCT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    BINHLUAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HINHANH = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NGAYDANG = table.Column<DateOnly>(type: "date", nullable: false),
                    SOSAO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DANHGIA__8597D60A7BE0A90B", x => x.MADANHGIA);
                    table.ForeignKey(
                        name: "FK__DANHGIA__MAKH__1BC821DD",
                        column: x => x.MAKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKH");
                    table.ForeignKey(
                        name: "FK__DANHGIA__MASPCT__1CBC4616",
                        column: x => x.MASPCT,
                        principalTable: "SANPHAMCT",
                        principalColumn: "MASPCT");
                });

            migrationBuilder.CreateTable(
                name: "GIOHANGCT",
                columns: table => new
                {
                    MAGHCT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAKH = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MASPCT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    TONGTIEN = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GIOHANGC__0CCE71FE27BF5E53", x => x.MAGHCT);
                    table.ForeignKey(
                        name: "FK__GIOHANGCT__MAKH__123EB7A3",
                        column: x => x.MAKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKH");
                    table.ForeignKey(
                        name: "FK__GIOHANGCT__MASPC__1332DBDC",
                        column: x => x.MASPCT,
                        principalTable: "SANPHAMCT",
                        principalColumn: "MASPCT");
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTDISCOUNTS",
                columns: table => new
                {
                    MADISCOUNTS = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DISCOUNTSNAME = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MASPCT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    BATDAU = table.Column<DateTime>(type: "datetime", nullable: false),
                    KETTHUC = table.Column<DateTime>(type: "datetime", nullable: false),
                    PHAMTRAMGIAM = table.Column<double>(type: "float", nullable: false),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRODUCTD__CC3E72D0C63B4F46", x => x.MADISCOUNTS);
                    table.ForeignKey(
                        name: "FK__PRODUCTDI__MASPC__2EDAF651",
                        column: x => x.MASPCT,
                        principalTable: "SANPHAMCT",
                        principalColumn: "MASPCT");
                });

            migrationBuilder.CreateTable(
                name: "HOADONCT",
                columns: table => new
                {
                    MAHDCT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAHD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MASPCT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SOLUONG = table.Column<double>(type: "float", nullable: false),
                    TONGTIEN = table.Column<double>(type: "float", nullable: false),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADONCT__1A700082BC549E62", x => x.MAHDCT);
                    table.ForeignKey(
                        name: "FK__HOADONCT__MAHD__282DF8C2",
                        column: x => x.MAHD,
                        principalTable: "HOADON",
                        principalColumn: "MAHD");
                    table.ForeignKey(
                        name: "FK__HOADONCT__MASPCT__29221CFB",
                        column: x => x.MASPCT,
                        principalTable: "SANPHAMCT",
                        principalColumn: "MASPCT");
                });

            migrationBuilder.CreateTable(
                name: "THANHTOAN",
                columns: table => new
                {
                    MATHANHTOAN = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAHD = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PHUONGTHUC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TONGTIEN = table.Column<double>(type: "float", nullable: false),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NGAYTHANHTOAN = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__THANHTOA__E5D8225C0FB93A6A", x => x.MATHANHTOAN);
                    table.ForeignKey(
                        name: "FK__THANHTOAN__MAHD__2BFE89A6",
                        column: x => x.MAHD,
                        principalTable: "HOADON",
                        principalColumn: "MAHD");
                });

            migrationBuilder.CreateTable(
                name: "ORDER",
                columns: table => new
                {
                    MAORDER = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAGHCT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MANV = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NGAYDAT = table.Column<DateTime>(type: "datetime", nullable: false),
                    TONGTIEN = table.Column<double>(type: "float", nullable: false),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ORDER__C8361541EDBF2273", x => x.MAORDER);
                    table.ForeignKey(
                        name: "FK__ORDER__MAGHCT__1F98B2C1",
                        column: x => x.MAGHCT,
                        principalTable: "GIOHANGCT",
                        principalColumn: "MAGHCT");
                    table.ForeignKey(
                        name: "FK__ORDER__MANV__208CD6FA",
                        column: x => x.MANV,
                        principalTable: "NHANVIEN",
                        principalColumn: "MANV");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DANHGIA_MAKH",
                table: "DANHGIA",
                column: "MAKH");

            migrationBuilder.CreateIndex(
                name: "IX_DANHGIA_MASPCT",
                table: "DANHGIA",
                column: "MASPCT");

            migrationBuilder.CreateIndex(
                name: "IX_GIOHANGCT_MAKH",
                table: "GIOHANGCT",
                column: "MAKH");

            migrationBuilder.CreateIndex(
                name: "IX_GIOHANGCT_MASPCT",
                table: "GIOHANGCT",
                column: "MASPCT");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MAGIAMGIA",
                table: "HOADON",
                column: "MAGIAMGIA");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MAKH",
                table: "HOADON",
                column: "MAKH");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MANV",
                table: "HOADON",
                column: "MANV");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCT_MAHD",
                table: "HOADONCT",
                column: "MAHD");

            migrationBuilder.CreateIndex(
                name: "IX_HOADONCT_MASPCT",
                table: "HOADONCT",
                column: "MASPCT");

            migrationBuilder.CreateIndex(
                name: "IX_KHACHHANGVOUCHER_MAGIAMGIA",
                table: "KHACHHANGVOUCHER",
                column: "MAGIAMGIA");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_MACHUCVU",
                table: "NHANVIEN",
                column: "MACHUCVU");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_MAGHCT",
                table: "ORDER",
                column: "MAGHCT");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_MANV",
                table: "ORDER",
                column: "MANV");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTDISCOUNTS_MASPCT",
                table: "PRODUCTDISCOUNTS",
                column: "MASPCT");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MACHATLIEU",
                table: "SANPHAMCT",
                column: "MACHATLIEU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MALOAI",
                table: "SANPHAMCT",
                column: "MALOAI");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MAMAU",
                table: "SANPHAMCT",
                column: "MAMAU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MASIZE",
                table: "SANPHAMCT",
                column: "MASIZE");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MASP",
                table: "SANPHAMCT",
                column: "MASP");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MATHUONGHIEU",
                table: "SANPHAMCT",
                column: "MATHUONGHIEU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAMCT_MAXUATXU",
                table: "SANPHAMCT",
                column: "MAXUATXU");

            migrationBuilder.CreateIndex(
                name: "IX_THANHTOAN_MAHD",
                table: "THANHTOAN",
                column: "MAHD");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DANHGIA");

            migrationBuilder.DropTable(
                name: "GIOHANG");

            migrationBuilder.DropTable(
                name: "HOADONCT");

            migrationBuilder.DropTable(
                name: "KHACHHANGVOUCHER");

            migrationBuilder.DropTable(
                name: "ORDER");

            migrationBuilder.DropTable(
                name: "PRODUCTDISCOUNTS");

            migrationBuilder.DropTable(
                name: "THANHTOAN");

            migrationBuilder.DropTable(
                name: "GIOHANGCT");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "SANPHAMCT");

            migrationBuilder.DropTable(
                name: "VOUCHER");

            migrationBuilder.DropTable(
                name: "KHACHHANG");

            migrationBuilder.DropTable(
                name: "NHANVIEN");

            migrationBuilder.DropTable(
                name: "CHATLIEU");

            migrationBuilder.DropTable(
                name: "LOAI");

            migrationBuilder.DropTable(
                name: "MAU");

            migrationBuilder.DropTable(
                name: "SIZE");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "THUONGHIEU");

            migrationBuilder.DropTable(
                name: "XUATXU");

            migrationBuilder.DropTable(
                name: "CHUCVU");
        }
    }
}
