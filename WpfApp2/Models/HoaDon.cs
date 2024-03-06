using System;
using System.Collections.Generic;

namespace WpfApp2.Models;

public partial class HoaDon
{
    public string Id { get; set; } = null!;

    public string IdKhachHang { get; set; } = null!;

    public string IdNhanVien { get; set; } = null!;

    public string ThoiGian { get; set; } = null!;

    public decimal GiaVe { get; set; }

    public virtual KhachHang IdKhachHangNavigation { get; set; } = null!;

    public virtual NhanVien IdNhanVienNavigation { get; set; } = null!;

    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
