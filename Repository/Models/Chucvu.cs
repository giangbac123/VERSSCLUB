using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Chucvu
{
    public Guid Machucvu { get; set; }

    public string? Vaitro { get; set; }

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
