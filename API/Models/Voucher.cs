using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Voucher
{
    public int Mavoucher { get; set; }

    public string Tenvoucher { get; set; } = null!;

    public DateOnly Ngaytao { get; set; }

    public DateOnly Ngaybatdau { get; set; }

    public DateOnly Ngayketthuc { get; set; }

    public bool? Trangthai { get; set; }

    public double? Phantramgiam { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<Sanphamct> Sanphamcts { get; set; } = new List<Sanphamct>();

    public virtual ICollection<Khachhang> Makhachhangs { get; set; } = new List<Khachhang>();
}
