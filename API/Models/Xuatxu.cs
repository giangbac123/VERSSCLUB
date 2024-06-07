using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Xuatxu
{
    public int Maxuatxu { get; set; }

    public string Diadiemxuatxu { get; set; } = null!;

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
