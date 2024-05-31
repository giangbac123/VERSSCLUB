using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class DB : Migration
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
                    table.PrimaryKey("PK__CHATLIEU__80F939F859DE3E74", x => x.MACHATLIEU);
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
                    table.PrimaryKey("PK__CHUCVU__9FA9FD6A63B82CA5", x => x.MACHUCVU);
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
                    table.PrimaryKey("PK__KHACHHAN__603F592C7A2F8725", x => x.MAKH);
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
                    table.PrimaryKey("PK__LOAI__2F633F233194CD20", x => x.MALOAI);
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
                    table.PrimaryKey("PK__MAU__7B7346CF4EDAB570", x => x.MAMAU);
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
                    table.PrimaryKey("PK__SIZE__3DD4402B21BB97EE", x => x.MASIZE);
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
                    table.PrimaryKey("PK__THUONGHI__B319F6380D99287D", x => x.MATHUONGHIEU);
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
                    table.PrimaryKey("PK__VOUCHER__41C284390897AF3E", x => x.MAGIAMGIA);
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
                    table.PrimaryKey("PK__XUATXU__52D93EA2DB86FC4E", x => x.MAXUATXU);
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
                    table.PrimaryKey("PK__NHANVIEN__603F511417A7B9BB", x => x.MANV);
                    table.ForeignKey(
                        name: "FK__NHANVIEN__MACHUC__286302EC",
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
                    table.PrimaryKey("PK__GIOHANG__603F592C86B59871", x => x.MAKH);
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
                name: "SANPHAM",
                columns: table => new
                {
                    MASP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TENSP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MACHATLIEU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MAXUATXU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MATHUONGHIEU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MALOAI = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAM__60228A32C0ACF9A8", x => x.MASP);
                    table.ForeignKey(
                        name: "FK__SANPHAM__MACHATL__36B12243",
                        column: x => x.MACHATLIEU,
                        principalTable: "CHATLIEU",
                        principalColumn: "MACHATLIEU");
                    table.ForeignKey(
                        name: "FK__SANPHAM__MALOAI__398D8EEE",
                        column: x => x.MALOAI,
                        principalTable: "LOAI",
                        principalColumn: "MALOAI");
                    table.ForeignKey(
                        name: "FK__SANPHAM__MATHUON__38996AB5",
                        column: x => x.MATHUONGHIEU,
                        principalTable: "THUONGHIEU",
                        principalColumn: "MATHUONGHIEU");
                    table.ForeignKey(
                        name: "FK__SANPHAM__MAXUATX__37A5467C",
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
                    table.PrimaryKey("PK__HOADON__603F20CEBE120F43", x => x.MAHD);
                    table.ForeignKey(
                        name: "FK__HOADON__MAGIAMGI__571DF1D5",
                        column: x => x.MAGIAMGIA,
                        principalTable: "VOUCHER",
                        principalColumn: "MAGIAMGIA");
                    table.ForeignKey(
                        name: "FK__HOADON__MAKH__5535A963",
                        column: x => x.MAKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKH");
                    table.ForeignKey(
                        name: "FK__HOADON__MANV__5629CD9C",
                        column: x => x.MANV,
                        principalTable: "NHANVIEN",
                        principalColumn: "MANV");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAMCT",
                columns: table => new
                {
                    MASPCT = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    SOLUONG = table.Column<int>(type: "int", nullable: false),
                    GIA = table.Column<double>(type: "float", nullable: false),
                    MAMAU = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    TRANGTHAI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IMGURL = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    MASP = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    MASIZE = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAMC__3D158D8655F960C8", x => x.MASPCT);
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MAMAU__3C69FB99",
                        column: x => x.MAMAU,
                        principalTable: "MAU",
                        principalColumn: "MAMAU");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MASIZ__3E52440B",
                        column: x => x.MASIZE,
                        principalTable: "SIZE",
                        principalColumn: "MASIZE");
                    table.ForeignKey(
                        name: "FK__SANPHAMCT__MASP__3D5E1FD2",
                        column: x => x.MASP,
                        principalTable: "SANPHAM",
                        principalColumn: "MASP");
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
                    table.PrimaryKey("PK__THANHTOA__E5D8225CAF4E1865", x => x.MATHANHTOAN);
                    table.ForeignKey(
                        name: "FK__THANHTOAN__MAHD__5DCAEF64",
                        column: x => x.MAHD,
                        principalTable: "HOADON",
                        principalColumn: "MAHD");
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
                    table.PrimaryKey("PK__DANHGIA__8597D60A651052BC", x => x.MADANHGIA);
                    table.ForeignKey(
                        name: "FK__DANHGIA__MAKH__4D94879B",
                        column: x => x.MAKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKH");
                    table.ForeignKey(
                        name: "FK__DANHGIA__MASPCT__4E88ABD4",
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
                    table.PrimaryKey("PK__GIOHANGC__0CCE71FEB37E77F4", x => x.MAGHCT);
                    table.ForeignKey(
                        name: "FK__GIOHANGCT__MAKH__440B1D61",
                        column: x => x.MAKH,
                        principalTable: "KHACHHANG",
                        principalColumn: "MAKH");
                    table.ForeignKey(
                        name: "FK__GIOHANGCT__MASPC__44FF419A",
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
                    table.PrimaryKey("PK__HOADONCT__1A700082B03A597D", x => x.MAHDCT);
                    table.ForeignKey(
                        name: "FK__HOADONCT__MAHD__59FA5E80",
                        column: x => x.MAHD,
                        principalTable: "HOADON",
                        principalColumn: "MAHD");
                    table.ForeignKey(
                        name: "FK__HOADONCT__MASPCT__5AEE82B9",
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
                    table.PrimaryKey("PK__PRODUCTD__CC3E72D04981D3A8", x => x.MADISCOUNTS);
                    table.ForeignKey(
                        name: "FK__PRODUCTDI__MASPC__60A75C0F",
                        column: x => x.MASPCT,
                        principalTable: "SANPHAMCT",
                        principalColumn: "MASPCT");
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
                    table.PrimaryKey("PK__ORDER__C8361541552B4F2B", x => x.MAORDER);
                    table.ForeignKey(
                        name: "FK__ORDER__MAGHCT__5165187F",
                        column: x => x.MAGHCT,
                        principalTable: "GIOHANGCT",
                        principalColumn: "MAGHCT");
                    table.ForeignKey(
                        name: "FK__ORDER__MANV__52593CB8",
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
                name: "IX_SANPHAM_MACHATLIEU",
                table: "SANPHAM",
                column: "MACHATLIEU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MALOAI",
                table: "SANPHAM",
                column: "MALOAI");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MATHUONGHIEU",
                table: "SANPHAM",
                column: "MATHUONGHIEU");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MAXUATXU",
                table: "SANPHAM",
                column: "MAXUATXU");

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
                name: "MAU");

            migrationBuilder.DropTable(
                name: "SIZE");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "CHUCVU");

            migrationBuilder.DropTable(
                name: "CHATLIEU");

            migrationBuilder.DropTable(
                name: "LOAI");

            migrationBuilder.DropTable(
                name: "THUONGHIEU");

            migrationBuilder.DropTable(
                name: "XUATXU");
        }
    }
}
