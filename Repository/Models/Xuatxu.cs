using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Xuatxu
{
    public Guid Maxuatxu { get; set; }

    public string? Diadiemxuatxu { get; set; }

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();
}
