using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanThucAnNhanh.Models;

namespace WebBanThucAnNhanh.Areas.QuanLy.Controllers
{
    public class HoaDonController : Controller
    {

        QLThucAnNhanhEntities database = new QLThucAnNhanhEntities();
        // GET: QuanLy/HoaDon
        public ActionResult Index()
        {
            return View(database.HOADONs.ToList());
        }

        // GET: QuanLy/HoaDon/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuanLy/HoaDon/Create
        public ActionResult Details()
        {
            return View();
        }

        // POST: QuanLy/DonHang/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
