using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Sanpham
{
    public string Masp { get; set; } = null!;

    public string Tensp { get; set; } = null!;

    public string Trangthai { get; set; } = null!;

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
