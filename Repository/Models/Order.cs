using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Order
{
    public string Maorder { get; set; } = null!;

    public string Maghct { get; set; } = null!;

    public string Manv { get; set; } = null!;

    public DateTime Ngaydat { get; set; }

    public double Tongtien { get; set; }

    public string Trangthai { get; set; } = null!;

    public virtual Giohangct MaghctNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
