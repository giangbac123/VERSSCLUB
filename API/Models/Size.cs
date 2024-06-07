using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Size
{
    public int Masize { get; set; }

    public int Size1 { get; set; }

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
