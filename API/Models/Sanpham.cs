using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Sanpham
{
    public int Masanpham { get; set; }

    public int Magiohangct { get; set; }

    public string Tensanpham { get; set; } = null!;

    public int Machatlieu { get; set; }

    public int Maxuatxu { get; set; }

    public int Mathuonghieu { get; set; }

    public int Maloaisanpham { get; set; }

    public bool Trangthai { get; set; }

    public virtual Chatlieu MachatlieuNavigation { get; set; } = null!;

    public virtual Giohangct MagiohangctNavigation { get; set; } = null!;

    public virtual Loaisanpham MaloaisanphamNavigation { get; set; } = null!;

    public virtual Thuonghieu MathuonghieuNavigation { get; set; } = null!;

    public virtual Xuatxu MaxuatxuNavigation { get; set; } = null!;

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
