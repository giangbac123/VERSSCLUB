using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Thuonghieu
{
    public Guid Mathuonghieu { get; set; }

    public string? Tenthuonghieu { get; set; }

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
