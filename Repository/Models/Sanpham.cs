using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Sanpham
{
    public Guid Masp { get; set; }

    public string? Tensanpham { get; set; }

    public string Trangthai { get; set; } = null!;

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
