using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Chucvu
{
    public string Machucvu { get; set; } = null!;

    public string Vaitro { get; set; } = null!;

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
