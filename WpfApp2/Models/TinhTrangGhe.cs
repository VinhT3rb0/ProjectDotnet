using System;
using System.Collections.Generic;

namespace WpfApp2.Models;

public partial class TinhTrangGhe
{
    public int IdGhe { get; set; }

    public int ShowtimeId { get; set; }

    public bool TinhTrang { get; set; }

    public virtual Ghe IdGheNavigation { get; set; } = null!;

    public virtual ShowTime Showtime { get; set; } = null!;
}
