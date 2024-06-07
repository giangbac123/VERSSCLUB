using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Loaisanpham
{
    public int Maloaisanpham { get; set; }

    public string Tenloai { get; set; } = null!;

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
