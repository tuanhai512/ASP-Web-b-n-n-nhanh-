using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanThucAnNhanh.Models;

namespace WebBanThucAnNhanh.Controllers
{
    public class HomeController : Controller
    {
        QLThucAnNhanhEntities _db = new QLThucAnNhanhEntities();
        public ActionResult Index()
        {
            return View(_db.MONANs.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Details(string id)
        {
            return View(_db.MONANs.Where(s => s.MAMONAN == id).FirstOrDefault());
        }
    }
}