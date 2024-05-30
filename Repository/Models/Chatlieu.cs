using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Chatlieu
{
    public Guid Machatlieu { get; set; }

    public string? Tenchatlieu { get; set; }

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
