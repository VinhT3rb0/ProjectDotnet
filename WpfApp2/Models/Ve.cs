using System;
using System.Collections.Generic;

namespace WpfApp2.Models;

public partial class Ve
{
    public int Id { get; set; }

    public string BillId { get; set; } = null!;

    public int ShowtimeId { get; set; }

    public int SeatId { get; set; }

    public decimal Price { get; set; }

    public int PhimId { get; set; }

    public int PhongId { get; set; }

    public virtual HoaDon Bill { get; set; } = null!;

    public virtual Phim Phim { get; set; } = null!;

    public virtual Phong Phong { get; set; } = null!;

    public virtual Ghe Seat { get; set; } = null!;

    public virtual ShowTime Showtime { get; set; } = null!;
}
