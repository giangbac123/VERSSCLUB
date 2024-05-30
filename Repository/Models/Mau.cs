using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Mau
{
    public Guid Mamau { get; set; }

    public string? Mausac { get; set; }

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
