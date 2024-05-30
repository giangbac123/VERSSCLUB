using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Size
{
    public string Masize { get; set; } = null!;

    public string Size1 { get; set; } = null!;

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
