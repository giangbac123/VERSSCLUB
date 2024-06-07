using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Thanhtoan
{
    public int Mathanhtoan { get; set; }

    public int Mahoadon { get; set; }

    public int Phuongthucthanhtoan { get; set; }

    public DateOnly Ngaythanhtoan { get; set; }

    public bool Trangthai { get; set; }

    public decimal Tongtien { get; set; }

    public virtual Hoadon MahoadonNavigation { get; set; } = null!;
}
