using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Sanphamct
{
    public int Masanphamct { get; set; }

    public string Tensanphamct { get; set; } = null!;

    public int Machatlieu { get; set; }

    public int Mamau { get; set; }

    public int Masanpham { get; set; }

    public int Maxuatxu { get; set; }

    public int Mathuonghieu { get; set; }

    public int Maloaisanpham { get; set; }

    public int Masize { get; set; }

    public int Soluong { get; set; }

    public bool Trangthai { get; set; }

    public string Imgurl { get; set; } = null!;

    public decimal Gia { get; set; }

    public virtual ICollection<Danhgium> Danhgia { get; set; } = new List<Danhgium>();

    public virtual ICollection<Giamgium> Giamgia { get; set; } = new List<Giamgium>();

    public virtual ICollection<Hoadonct> Hoadoncts { get; set; } = new List<Hoadonct>();

    public virtual Chatlieu MachatlieuNavigation { get; set; } = null!;

    public virtual Loaisanpham MaloaisanphamNavigation { get; set; } = null!;

    public virtual Loaimau MamauNavigation { get; set; } = null!;

    public virtual Sanpham MasanphamNavigation { get; set; } = null!;

    public virtual Size MasizeNavigation { get; set; } = null!;

    public virtual Voucher MathuonghieuNavigation { get; set; } = null!;

    public virtual Xuatxu MaxuatxuNavigation { get; set; } = null!;
}
