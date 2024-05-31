using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Sanpham
{
    public string Masp { get; set; } = null!;

    public string Tensp { get; set; } = null!;

    public string Trangthai { get; set; } = null!;

    public string Machatlieu { get; set; } = null!;

    public string Maxuatxu { get; set; } = null!;

    public string Mathuonghieu { get; set; } = null!;

    public string Maloai { get; set; } = null!;

    public virtual Chatlieu MachatlieuNavigation { get; set; } = null!;

    public virtual Loai MaloaiNavigation { get; set; } = null!;

    public virtual Thuonghieu MathuonghieuNavigation { get; set; } = null!;

    public virtual Xuatxu MaxuatxuNavigation { get; set; } = null!;

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
