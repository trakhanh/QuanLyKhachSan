using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class Phong
    {
        public Phong()
        {
            DatPhongs = new HashSet<DatPhong>();
        }

        public int MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int MaLoaiPhong { get; set; }
        public int MaTinhTrang { get; set; }

        public virtual LoaiPhong MaLoaiPhongNavigation { get; set; }
        public virtual TinhTrangPhong MaTinhTrangNavigation { get; set; }
        public virtual ICollection<DatPhong> DatPhongs { get; set; }
    }
}
