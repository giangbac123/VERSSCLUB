using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Khachhang
{
    public Guid Makh { get; set; }

    public string? Hoten { get; set; }

    public bool? Gioitinh { get; set; }

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public string? Matkhau { get; set; }

    public DateOnly? Ngaysinh { get; set; }

    public virtual Giohang? Giohang { get; set; }
}
