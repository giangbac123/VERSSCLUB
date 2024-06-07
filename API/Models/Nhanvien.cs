using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Nhanvien
{
    public int Manhanvien { get; set; }

    public string Tennhanvien { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Matkhau { get; set; } = null!;

    public int? Namsinh { get; set; }

    public bool? Trangthai { get; set; }

    public int? Machucvu { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual Chucvu? MachucvuNavigation { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
