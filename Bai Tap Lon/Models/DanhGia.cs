using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai_Tap_Lon.Models
{
    [Table("DanhGias")]
    public class DanhGia
    {
        [Key]

        public int Sosao { get; set; }

        public string Danhgiachatluong { get; set; }
        [AllowHtml]
        public string PhanHoiKhachHang { get; set; }
    }
}