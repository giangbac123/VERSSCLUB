using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Mau
{
    public string Mamau { get; set; } = null!;

    public string Mau1 { get; set; } = null!;

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
