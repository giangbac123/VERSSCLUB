using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Thanhtoan
{
    public string Mathanhtoan { get; set; } = null!;

    public string Mahd { get; set; } = null!;

    public string Phuongthuc { get; set; } = null!;

    public double Tongtien { get; set; }

    public string Trangthai { get; set; } = null!;

    public DateTime Ngaythanhtoan { get; set; }

    public virtual Hoadon MahdNavigation { get; set; } = null!;
}
