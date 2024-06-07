using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Chucvu
{
    public int Machucvu { get; set; }

    public string Vaitro { get; set; } = null!;

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
