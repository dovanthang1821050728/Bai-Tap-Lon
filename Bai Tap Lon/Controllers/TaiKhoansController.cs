using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Bai_Tap_Lon.Models;

namespace Bai_Tap_Lon.Controllers
{
    public class TaiKhoansController : Controller
    {
        // GET: TaiKhoans
        Encryption encry = new Encryption();
        KhachHangDbContext db = new KhachHangDbContext();
        // GET: Account
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(usder acc)
        {
            if (ModelState.IsValid)
            {
                acc.MatKhau = encry.PasswordEncryption(acc.MatKhau);
                db.usders.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "TaiKhoans");
            }
            return View(acc);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(usder acc)
        {
            if (ModelState.IsValid)
            {
                string encryptionpass = encry.PasswordEncryption(acc.MatKhau);
                var model = db.TaiKhoans.Where(m => m.TenDangNhap == acc.TenDangNhap && m.MatKhau == encryptionpass).ToList().Count();
                if (model == 1)
                {
                    FormsAuthentication.SetAuthCookie(acc.TenDangNhap, true);
                   
                    return View("Index", "ThongTinKhachHangs");
                   
                }
                else
                {
                    ModelState.AddModelError(" ", "Thông Tin Đăng Nhập Không Chính Xác");
                }
            }
            return View(acc);
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}