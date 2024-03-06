using System;
using System.Collections.Generic;

namespace WpfApp2.Models;

public partial class Phim
{
    public int Id { get; set; }

    public string TenPhim { get; set; } = null!;

    public string QuocGia { get; set; } = null!;

    public string TheLoai { get; set; } = null!;

    public string DaoDien { get; set; } = null!;

    public string MoTa { get; set; } = null!;

    public string HinhAnh { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public TimeOnly ThoiLuong { get; set; }

    public virtual ICollection<ShowTime> ShowTimes { get; set; } = new List<ShowTime>();

    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
