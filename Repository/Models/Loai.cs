using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Loai
{
    public Guid Maloai { get; set; }

    public string? Tenloai { get; set; }

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
