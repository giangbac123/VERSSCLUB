using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Danhgium
{
    public string Madanhgia { get; set; } = null!;

    public string Makh { get; set; } = null!;

    public string Maspct { get; set; } = null!;

    public string? Binhluan { get; set; }

    public string? Hinhanh { get; set; }

    public DateOnly Ngaydang { get; set; }

    public int? Sosao { get; set; }

    public virtual Khachhang MakhNavigation { get; set; } = null!;

    public virtual Sanphamct MaspctNavigation { get; set; } = null!;
}
