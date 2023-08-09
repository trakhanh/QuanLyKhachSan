using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class LoaiPhong
    {
        public LoaiPhong()
        {
            Phongs = new HashSet<Phong>();
        }

        public int MaLoaiPhong { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string TenLoaiPhong { get; set; }
        public int DonGia { get; set; }

        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
