using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Giohang
{
    public int Magiohang { get; set; }

    public int? Makhachhang { get; set; }

    public virtual ICollection<Giohangct> Giohangcts { get; set; } = new List<Giohangct>();

    public virtual Khachhang? MakhachhangNavigation { get; set; }
}
