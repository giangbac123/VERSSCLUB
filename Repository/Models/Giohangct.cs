using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Giohangct
{
    public int Magiohangct { get; set; }

    public int Makhachhang { get; set; }

    public int Magiohang { get; set; }

    public int Soluong { get; set; }

    public decimal Tongtien { get; set; }

    public virtual Giohang MagiohangNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
