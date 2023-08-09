using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class TinhTrangPhong
    {
        public TinhTrangPhong()
        {
            Phongs = new HashSet<Phong>();
        }

        public int MaTinhTrang { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string TenTinhTrang { get; set; }

        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
