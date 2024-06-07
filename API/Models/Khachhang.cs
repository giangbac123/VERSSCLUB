using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Khachhang
{
    public int Makhachhang { get; set; }

    public string Tenkhachhang { get; set; } = null!;

    public bool? Gioitinh { get; set; }

    public string Sdt { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Diachi { get; set; }

    public string Matkhau { get; set; } = null!;

    public DateOnly? Ngaysinh { get; set; }

    public virtual ICollection<Danhgium> Danhgia { get; set; } = new List<Danhgium>();

    public virtual ICollection<Giohang> Giohangs { get; set; } = new List<Giohang>();

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<Voucher> Mavouchers { get; set; } = new List<Voucher>();
}
