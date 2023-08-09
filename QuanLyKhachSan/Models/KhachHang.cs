using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace QuanLyKhachSan.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DatPhongs = new HashSet<DatPhong>();
        }

        public int MaKhachHang { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string HoTen { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgaySinh { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string DiaChi { get; set; }

        public string Sdt { get; set; }
        public string Email { get; set; }

        public virtual ICollection<DatPhong> DatPhongs { get; set; }
    }
}
