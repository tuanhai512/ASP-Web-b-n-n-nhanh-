using WebBanThucAnNhanh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanThucAnNhanh.Areas.NhanVien.Controllers
{
    public class LoginUserController : Controller
    {
        QLThucAnNhanhEntities database = new QLThucAnNhanhEntities();
        // GET: LoginUser
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginAccount() {
            return View();
        }
        [HttpPost]
        public ActionResult LoginAccount(NHANVIEN _user)
        {
            var check = database.NHANVIEN.Where(s => s.EMAIL == _user.EMAIL && s.PASSWORD== _user.PASSWORD).FirstOrDefault();
                if(check == null)
                {
                    ViewBag.ErrorInfo = "Sai info";
                    return View("Index");
                }    
                else
                {
                    database.Configuration.ValidateOnSaveEnabled = false;
                    Session["EMAIL"] = _user.EMAIL;
                    Session["PASSWORD"] = _user.PASSWORD;
                    return RedirectToAction("Index", "MonAn");
                }    
            return View();
        }
       
    }
}