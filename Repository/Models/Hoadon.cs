using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Hoadon
{
    public string Mahd { get; set; } = null!;

    public string Makh { get; set; } = null!;

    public string Manv { get; set; } = null!;

    public string Magiamgia { get; set; } = null!;

    public string? Ghichu { get; set; }

    public double Tongtien { get; set; }

    public DateTime Ngaytao { get; set; }

    public string? Trangthai { get; set; }

    public virtual ICollection<Hoadonct> Hoadoncts { get; set; } = new List<Hoadonct>();

    public virtual Voucher MagiamgiaNavigation { get; set; } = null!;

    public virtual Khachhang MakhNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;

    public virtual ICollection<Thanhtoan> Thanhtoans { get; set; } = new List<Thanhtoan>();
}
