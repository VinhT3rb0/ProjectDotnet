using System;
using System.Collections.Generic;

namespace WpfApp2.Models;

public partial class Ghe
{
    public int Id { get; set; }

    public int SoGhe { get; set; }

    public string HangGhe { get; set; } = null!;

    public int IdPhong { get; set; }

    public virtual Phong IdPhongNavigation { get; set; } = null!;

    public virtual TinhTrangGhe? TinhTrangGhe { get; set; }

    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
