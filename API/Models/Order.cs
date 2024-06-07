using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Order
{
    public int Maorder { get; set; }

    public int Magiohangct { get; set; }

    public int Manhanvien { get; set; }

    public DateOnly Ngaydathang { get; set; }

    public decimal TongTien { get; set; }

    public bool TrangThai { get; set; }

    public virtual Giohangct MagiohangctNavigation { get; set; } = null!;

    public virtual Nhanvien ManhanvienNavigation { get; set; } = null!;
}
