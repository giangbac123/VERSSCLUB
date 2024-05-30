using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Xuatxu
{
    public string Maxuatxu { get; set; } = null!;

    public string Xuatxu1 { get; set; } = null!;

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
