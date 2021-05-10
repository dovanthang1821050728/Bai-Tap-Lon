using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai_Tap_Lon.Models
{
    [Table("SanPhams")]
    public class SanPham
    {
        [Key]

        public int MaSanPham { get; set; }
        [AllowHtml]
        public string TenSanPham { get; set; }

        public int SoLuongMua { get; set; }
        public int NgayMua { get; set; }

        public string Diachicuahang { get; set; }
    }
}