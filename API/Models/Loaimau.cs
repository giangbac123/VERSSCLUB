using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Loaimau
{
    public int Mamau { get; set; }

    public string Tenmau { get; set; } = null!;

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
