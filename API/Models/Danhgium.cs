using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Danhgium
{
    public int Madanhgia { get; set; }

    public int? Masanphamct { get; set; }

    public int? Makhachhang { get; set; }

    public string? Mota { get; set; }

    public string? Hinhanh { get; set; }

    public DateOnly? Ngaydang { get; set; }

    public int? Sosao { get; set; }

    public virtual Khachhang? MakhachhangNavigation { get; set; }

    public virtual Sanphamct? MasanphamctNavigation { get; set; }
}
