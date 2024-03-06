using System;
using System.Collections.Generic;

namespace WpfApp2.Models;

public partial class ShowTime
{
    public int Id { get; set; }

    public int ShowTimeSettingId { get; set; }

    public int MovieId { get; set; }

    public decimal GiaVe { get; set; }

    public TimeOnly ThoiGianVao { get; set; }

    public virtual Phim Movie { get; set; } = null!;

    public virtual ICollection<TinhTrangGhe> TinhTrangGhes { get; set; } = new List<TinhTrangGhe>();

    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
