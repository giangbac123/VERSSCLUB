using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Hoadon
{
    public int Mahoadon { get; set; }

    public int Makhachhang { get; set; }

    public int Mavoucher { get; set; }

    public int Manhanvien { get; set; }

    public DateOnly Ngaytao { get; set; }

    public bool Trangthai { get; set; }

    public string? Ghichu { get; set; }

    public decimal Tongtien { get; set; }

    public virtual ICollection<Hoadonct> Hoadoncts { get; set; } = new List<Hoadonct>();

    public virtual Khachhang MakhachhangNavigation { get; set; } = null!;

    public virtual Nhanvien ManhanvienNavigation { get; set; } = null!;

    public virtual Voucher MavoucherNavigation { get; set; } = null!;

    public virtual ICollection<Thanhtoan> Thanhtoans { get; set; } = new List<Thanhtoan>();
}
