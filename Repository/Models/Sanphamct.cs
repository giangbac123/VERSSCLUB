using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Sanphamct
{
    public Guid Maspct { get; set; }

    public int? Soluong { get; set; }

    public double? Gia { get; set; }

    public Guid? Machatlieu { get; set; }

    public Guid? Mamau { get; set; }

    public string? Trangthai { get; set; }

    public string? Imgurl { get; set; }

    public Guid? Masp { get; set; }

    public Guid? Maxuatxu { get; set; }

    public Guid? Mathuonghieu { get; set; }

    public Guid? Maloai { get; set; }

    public Guid? Masize { get; set; }

    public virtual Chatlieu? MachatlieuNavigation { get; set; }

    public virtual Loai? MaloaiNavigation { get; set; }

    public virtual Mau? MamauNavigation { get; set; }

    public virtual Sanpham? MaspNavigation { get; set; }

    public virtual Thuonghieu? MathuonghieuNavigation { get; set; }

    public virtual Xuatxu? MaxuatxuNavigation { get; set; }
}
