using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Hoadonct
{
    public int Mahoadonct { get; set; }

    public int Mahoadon { get; set; }

    public int Masanphamct { get; set; }

    public int Soluong { get; set; }

    public decimal Tongtien { get; set; }

    public bool Trangthai { get; set; }

    public virtual Hoadon MahoadonNavigation { get; set; } = null!;

    public virtual Sanphamct MasanphamctNavigation { get; set; } = null!;
}
