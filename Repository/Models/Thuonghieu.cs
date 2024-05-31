using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Thuonghieu
{
    public string Mathuonghieu { get; set; } = null!;

    public string Tenthuonghieu { get; set; } = null!;

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
