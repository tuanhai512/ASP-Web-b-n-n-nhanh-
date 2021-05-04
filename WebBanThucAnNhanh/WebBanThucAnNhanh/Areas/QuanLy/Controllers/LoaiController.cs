using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanThucAnNhanh.Models;

namespace WebBanThucAnNhanh.Areas.QuanLy.Controllers
{
    public class LoaiController : Controller
    {
        QLThucAnNhanhEntities database = new QLThucAnNhanhEntities();
        // GET: Loai
        public ActionResult Index()
        {
            return View(database.LOAIs.ToList());
        }

        public PartialViewResult LoaiPartial()
        {
            var loaiList = database.LOAIs.ToList();
            return PartialView(loaiList);
        }
        // GET: QuanLy/Loai
      
    }
}