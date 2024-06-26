
CREATE DATABASE VERSSCLUB22
GO
USE VERSSCLUB22
GO
CREATE TABLE CHUCVU(
	MACHUCVU	INT IDENTITY(1,1) PRIMARY KEY,
	VAITRO		NVARCHAR(50) NOT NULL
)
go
CREATE TABLE THUONGHIEU(
	MATHUONGHIEU	INT IDENTITY(1,1) PRIMARY KEY,
	TENTHUONGHIEU	NVARCHAR(50) NOT NULL
)
go
CREATE TABLE LOAISANPHAM(
	MALOAISANPHAM	INT IDENTITY(1,1) PRIMARY KEY,
	TENLOAI	NVARCHAR(50) NOT NULL
)
go
CREATE TABLE CHATLIEU(
	MACHATLIEU	INT IDENTITY(1,1) PRIMARY KEY,
	TENCHATLIEU	NVARCHAR(50) NOT NULL
)
go
CREATE TABLE XUATXU(
	MAXUATXU	INT IDENTITY(1,1) PRIMARY KEY,
	DIADIEMXUATXU	TEXT NOT NULL
)
go
CREATE TABLE SIZE(
	MASIZE	INT IDENTITY(1,1) PRIMARY KEY,
	SIZE	INT NOT NULL
)

go
CREATE TABLE LOAIMAU(
	MAMAU	INT IDENTITY(1,1) PRIMARY KEY,
	TENMAU	NVARCHAR(50) NOT NULL
)

go
CREATE TABLE NHANVIEN(
	MANHANVIEN	INT IDENTITY(1,1) PRIMARY KEY,
	TENNHANVIEN	NVARCHAR(50) NOT NULL,
	SDT VARCHAR(15) NOT NULL,
	EMAIL VARCHAR(100) NOT NULL,
	MATKHAU VARCHAR(50) NOT NULL,
	NAMSINH INT,
	TRANGTHAI BIT,
	MACHUCVU INT,
	CONSTRAINT FK_CHUCVU FOREIGN KEY (MACHUCVU) REFERENCES CHUCVU(MACHUCVU)
)

go
CREATE TABLE KHACHHANG(
	MAKHACHHANG	INT IDENTITY(1,1) PRIMARY KEY,
	TENKHACHHANG	NVARCHAR(50) NOT NULL,
	GIOITINH BIT,
	SDT VARCHAR(15) NOT NULL,
	EMAIL VARCHAR(100) NOT NULL,
	DIACHI TEXT,
	MATKHAU VARCHAR(50) NOT NULL,
	NGAYSINH DATE,
)

go
CREATE TABLE GIOHANG (
    MAGIOHANG INT IDENTITY(1,1) PRIMARY KEY,
    MAKHACHHANG INT,
    FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG(MAKHACHHANG)
)

go
CREATE TABLE GIOHANGCT (
    MAGIOHANGCT INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    MAKHACHHANG INT NOT NULL,
	MAGIOHANG	INT NOT NULL,
    SOLUONG INT NOT NULL,
    TONGTIEN DECIMAL NOT NULL,
	FOREIGN KEY (MAGIOHANG) REFERENCES GIOHANG(MAGIOHANG)
)

go
CREATE TABLE VOUCHER(
	MAVOUCHER	INT IDENTITY(1,1) PRIMARY KEY,
	TENVOUCHER NVARCHAR(100) NOT NULL,
	NGAYTAO	DATE NOT NULL,
	NGAYBATDAU DATE NOT NULL,
	NGAYKETTHUC		DATE NOT NULL,
	TRANGTHAI	BIT,
	PHANTRAMGIAM	FLOAT
)
go
CREATE TABLE KHACHHANG_VOUCHER(
	MAKHACHHANG	INT NOT NULL,
	MAVOUCHER	INT NOT NULL
	PRIMARY KEY (MAKHACHHANG, MAVOUCHER),
    FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG(MAKHACHHANG),
    FOREIGN KEY (MAVOUCHER) REFERENCES VOUCHER(MAVOUCHER)
)

go
CREATE TABLE HOADON(
	MAHOADON	INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MAKHACHHANG INT NOT NULL,
	MAVOUCHER	INT NOT NULL,
	MANHANVIEN	INT NOT NULL,
	NGAYTAO	DATE NOT NULL,
	TRANGTHAI	BIT NOT NULL,
	GHICHU	TEXT NULL,
	TONGTIEN DECIMAL NOT NULL
	FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG(MAKHACHHANG),
    FOREIGN KEY (MANHANVIEN) REFERENCES NHANVIEN(MANHANVIEN),
    FOREIGN KEY (MAVOUCHER) REFERENCES VOUCHER(MAVOUCHER),
)
go
CREATE TABLE THANHTOAN(
	MATHANHTOAN	INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MAHOADON INT NOT NULL,
	PHUONGTHUCTHANHTOAN INT NOT NULL,
	NGAYTHANHTOAN	DATE NOT NULL,
	TRANGTHAI	BIT NOT NULL,
	TONGTIEN DECIMAL NOT NULL
	FOREIGN KEY (MAHOADON) REFERENCES HOADON(MAHOADON)
)

go
CREATE TABLE SANPHAM(
	MASANPHAM	INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MAGIOHANGCT	INT NOT NULL,
	TENSANPHAM	NVARCHAR(50) NOT NULL,
	MACHATLIEU INT NOT NULL,
	MAXUATXU	INT NOT NULL,
	MATHUONGHIEU	INT NOT NULL,
	MALOAISANPHAM	INT NOT NULL,
	TRANGTHAI	BIT NOT NULL,
	FOREIGN KEY (MAGIOHANGCT) REFERENCES GIOHANGCT(MAGIOHANGCT),
	FOREIGN KEY (MACHATLIEU) REFERENCES CHATLIEU(MACHATLIEU),
	FOREIGN KEY (MAXUATXU) REFERENCES XUATXU(MAXUATXU),
	FOREIGN KEY (MATHUONGHIEU) REFERENCES THUONGHIEU(MATHUONGHIEU),
	FOREIGN KEY (MALOAISANPHAM) REFERENCES LOAISANPHAM(MALOAISANPHAM)
)
go
CREATE TABLE SANPHAMCT(
	MASANPHAMCT	INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TENSANPHAMCT	NVARCHAR(50) NOT NULL,
	MACHATLIEU INT NOT NULL,
	MAMAU	INT NOT NULL,
	MASANPHAM	INT NOT NULL,
	MAXUATXU	INT NOT NULL,
	MATHUONGHIEU	INT NOT NULL,
	MALOAISANPHAM	INT NOT NULL,
	MASIZE	INT NOT NULL,
	SOLUONG INT NOT NULL,
	TRANGTHAI	BIT NOT NULL,
	IMGURL TEXT NOT NULL,
	GIA DECIMAL NOT NULL,
	FOREIGN KEY (MACHATLIEU) REFERENCES CHATLIEU(MACHATLIEU),
    FOREIGN KEY (MAMAU) REFERENCES LOAIMAU(MAMAU),
    FOREIGN KEY (MASANPHAM) REFERENCES SANPHAM(MASANPHAM),
	FOREIGN KEY (MAXUATXU) REFERENCES XUATXU(MAXUATXU),
	FOREIGN KEY (MATHUONGHIEU) REFERENCES VOUCHER(MAVOUCHER),
	FOREIGN KEY (MALOAISANPHAM) REFERENCES LOAISANPHAM(MALOAISANPHAM),
	FOREIGN KEY (MASIZE) REFERENCES SIZE(MASIZE)
)
go
CREATE TABLE GIAMGIA(
	MAGIAMGIA	INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	TENGIAMGIA	NVARCHAR(50) NOT NULL,
	MASANPHAMCT INT NOT NULL,
	NGAYTAO DATETIME NOT NULL,
	NGAYBATDAU DATE NOT NULL,
	NGAYKETTHUC DATE NOT NULL,
	TRANGTHAI	BIT NOT NULL,
	TILEGIAMGIA FLOAT NOT NULL,
	FOREIGN KEY (MASANPHAMCT) REFERENCES SANPHAMCT(MASANPHAMCT)
)

go
CREATE TABLE HOADONCT(
	MAHOADONCT	INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MAHOADON INT NOT NULL,
	MASANPHAMCT INT NOT NULL,
	SOLUONG INT NOT NULL,
	TONGTIEN DECIMAL NOT NULL,
	TRANGTHAI	BIT NOT NULL,
	FOREIGN KEY (MAHOADON) REFERENCES HOADON(MAHOADON),
	FOREIGN KEY (MASANPHAMCT) REFERENCES SANPHAMCT(MASANPHAMCT)
)


go
CREATE TABLE [ORDER] (
    MAORDER INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	MAGIOHANGCT INT NOT NULL,
    MANHANVIEN INT NOT NULL,
    NGAYDATHANG DATE NOT NULL,
    TongTien DECIMAL NOT NULL,
    TrangThai BIT NOT NULL,
	FOREIGN KEY (MANHANVIEN) REFERENCES NHANVIEN(MANHANVIEN),
	FOREIGN KEY (MAGIOHANGCT) REFERENCES GIOHANGCT(MAGIOHANGCT)   
)

go
CREATE TABLE DANHGIA (
    MADANHGIA INT PRIMARY KEY,
    MASANPHAMCT INT,
    MAKHACHHANG INT,
    MOTA TEXT,
	HINHANH TEXT,
	NGAYDANG DATE,
	SOSAO INT,
	FOREIGN KEY (MASANPHAMCT) REFERENCES SANPHAMCT(MASANPHAMCT),
	FOREIGN KEY (MAKHACHHANG) REFERENCES KHACHHANG(MAKHACHHANG)
)
go
