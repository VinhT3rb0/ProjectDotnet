using System;
using System.Collections.Generic;

namespace WpfApp2.Models;

public partial class Phong
{
    public int Id { get; set; }

    public int SoLuongGhe { get; set; }

    public virtual ICollection<Ghe> Ghes { get; set; } = new List<Ghe>();

    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
