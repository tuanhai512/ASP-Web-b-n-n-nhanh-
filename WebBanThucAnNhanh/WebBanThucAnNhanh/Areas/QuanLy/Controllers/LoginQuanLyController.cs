using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanThucAnNhanh.Models;

namespace WebBanThucAnNhanh.Areas.QuanLy.Controllers
{
    public class LoginQuanLyController : Controller
    {
        // GET: QuanLy/LoginQuanLy
        QLThucAnNhanhEntities database = new QLThucAnNhanhEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginAccount()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginAccount(ADMIN _user)
        {
            var check = database.ADMINs.Where(s => s.Email == _user.Email && s.Pass == _user.Pass).FirstOrDefault();
            if (check == null)
            {
                ViewBag.ErrorInfo = "Sai info";
                return View("Index");
            }
            else
            {
                database.Configuration.ValidateOnSaveEnabled = false;
                Session["Email"] = _user.Email;
                Session["Pass"] = _user.Pass;
                return RedirectToAction("Index", "Account");
            }
            return View();
        }
    }
}