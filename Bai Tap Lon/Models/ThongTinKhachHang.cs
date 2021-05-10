using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai_Tap_Lon.Models
{
    [Table("ThongTinKhachHangs")]
    public class ThongTinKhachHang
    {
        public int ID { get; set; }
        public string TenKhachHang { get; set; }
        [AllowHtml]
        public string DiaChi { get; set; }
        public int SoDienThoai { get; set; }
    }
}