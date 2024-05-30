using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Nhanvien
{
    public string Manv { get; set; } = null!;

    public string? Tenkhachhang { get; set; }

    public bool Gioitinh { get; set; }

    public string Sdt { get; set; } = null!;

    public string Diachi { get; set; } = null!;

    public string Matkhau { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly Ngaysinh { get; set; }

    public string Trangthai { get; set; } = null!;

    public string Machucvu { get; set; } = null!;

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual Chucvu MachucvuNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
