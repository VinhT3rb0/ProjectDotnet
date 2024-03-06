using System;
using System.Collections.Generic;

namespace WpfApp2.Models;

public partial class NhanVien
{
    public string Id { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string TaiKhoan { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public DateTime NgaySinh { get; set; }

    public string GioiTinh { get; set; } = null!;

    public string ChucVu { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
