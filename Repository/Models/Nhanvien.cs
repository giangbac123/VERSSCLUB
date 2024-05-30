using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Nhanvien
{
    public Guid Manv { get; set; }

    public string? Tennhanvien { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public string? Matkhau { get; set; }

    public DateOnly? Namsinh { get; set; }

    public string? Trangthai { get; set; }

    public Guid? Machucvu { get; set; }

    public virtual Chucvu? MachucvuNavigation { get; set; }
}
