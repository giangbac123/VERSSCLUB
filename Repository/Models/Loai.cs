using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Loai
{
    public string Maloai { get; set; } = null!;

    public string Tenloai { get; set; } = null!;

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
