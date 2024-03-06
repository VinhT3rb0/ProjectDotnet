using System;
using System.Collections.Generic;

namespace WpfApp2.Models;

public partial class KhachHang
{
    public string Id { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public int Tuoi { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
