using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Voucher
{
    public string Magiamgia { get; set; } = null!;

    public string Tenma { get; set; } = null!;

    public DateTime Batdau { get; set; }

    public DateTime Ketthuc { get; set; }

    public string Trangthai { get; set; } = null!;

    public double Phantramgiam { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<Khachhang> Makhs { get; set; } = new List<Khachhang>();
}
