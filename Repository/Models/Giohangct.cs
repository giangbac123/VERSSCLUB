﻿using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Giohangct
{
    public string Maghct { get; set; } = null!;

    public string Makh { get; set; } = null!;

    public string Maspct { get; set; } = null!;

    public int Soluong { get; set; }

    public double Tongtien { get; set; }

    public virtual Khachhang MakhNavigation { get; set; } = null!;

    public virtual Sanphamct MaspctNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
