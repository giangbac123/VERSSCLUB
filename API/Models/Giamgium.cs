using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Giamgium
{
    public int Magiamgia { get; set; }

    public string Tengiamgia { get; set; } = null!;

    public int Masanphamct { get; set; }

    public DateTime Ngaytao { get; set; }

    public DateOnly Ngaybatdau { get; set; }

    public DateOnly Ngayketthuc { get; set; }

    public bool Trangthai { get; set; }

    public double Tilegiamgia { get; set; }

    public virtual Sanphamct MasanphamctNavigation { get; set; } = null!;
}
