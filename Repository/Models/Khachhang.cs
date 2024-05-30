using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Khachhang
{
    public string Makh { get; set; } = null!;

    public string Hoten { get; set; } = null!;

    public bool Gioitinh { get; set; }

    public string Sdt { get; set; } = null!;

    public string Diachi { get; set; } = null!;

    public string Matkhau { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateOnly Ngaysinh { get; set; }

    public virtual ICollection<Danhgium> Danhgia { get; set; } = new List<Danhgium>();

    public virtual Giohang? Giohang { get; set; }

    public virtual ICollection<Giohangct> Giohangcts { get; set; } = new List<Giohangct>();

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<Voucher> Magiamgia { get; set; } = new List<Voucher>();
}
