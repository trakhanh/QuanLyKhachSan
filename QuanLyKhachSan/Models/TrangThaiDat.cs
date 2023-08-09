using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class TrangThaiDat
    {
        public TrangThaiDat()
        {
            DatPhongs = new HashSet<DatPhong>();
        }

        public int MaTrangThai { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string TenTrangThai { get; set; }

        public virtual ICollection<DatPhong> DatPhongs { get; set; }
    }
}
