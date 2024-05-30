using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Hoadonct
{
    public string Mahdct { get; set; } = null!;

    public string Mahd { get; set; } = null!;

    public string Maspct { get; set; } = null!;

    public double Soluong { get; set; }

    public double Tongtien { get; set; }

    public string Trangthai { get; set; } = null!;

    public virtual Hoadon MahdNavigation { get; set; } = null!;

    public virtual Sanphamct MaspctNavigation { get; set; } = null!;
}
