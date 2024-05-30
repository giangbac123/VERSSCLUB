using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Giohang
{
    public string Makh { get; set; } = null!;

    public virtual Khachhang MakhNavigation { get; set; } = null!;
}
