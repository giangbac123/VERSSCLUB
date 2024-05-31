using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Chatlieu
{
    public string Machatlieu { get; set; } = null!;

    public string Tenchatlieu { get; set; } = null!;

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
