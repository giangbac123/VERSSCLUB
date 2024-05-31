﻿using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Sanphamct
{
    public string Maspct { get; set; } = null!;

    public int Soluong { get; set; }

    public double Gia { get; set; }

    public string Mamau { get; set; } = null!;

    public string Trangthai { get; set; } = null!;

    public string Imgurl { get; set; } = null!;

    public string Masp { get; set; } = null!;

    public string Masize { get; set; } = null!;

    public virtual ICollection<Danhgium> Danhgia { get; set; } = new List<Danhgium>();

    public virtual ICollection<Giohangct> Giohangcts { get; set; } = new List<Giohangct>();

    public virtual ICollection<Hoadonct> Hoadoncts { get; set; } = new List<Hoadonct>();

    public virtual Mau MamauNavigation { get; set; } = null!;

    public virtual Size MasizeNavigation { get; set; } = null!;

    public virtual Sanpham MaspNavigation { get; set; } = null!;

    public virtual ICollection<Productdiscount> Productdiscounts { get; set; } = new List<Productdiscount>();
}
