using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Giohang
{
    public Guid Makh { get; set; }

    public virtual Khachhang MakhNavigation { get; set; } = null!;
}
