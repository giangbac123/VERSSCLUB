using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Productdiscount
{
    public string Madiscounts { get; set; } = null!;

    public string Discountsname { get; set; } = null!;

    public string Maspct { get; set; } = null!;

    public DateTime Batdau { get; set; }

    public DateTime Ketthuc { get; set; }

    public double Phamtramgiam { get; set; }

    public string Trangthai { get; set; } = null!;

    public virtual Sanphamct MaspctNavigation { get; set; } = null!;
}
