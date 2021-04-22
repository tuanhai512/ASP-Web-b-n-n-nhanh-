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

        QLThucAnNhanhEntities _db = new QLThucAnNhanhEntities();
        // GET: QuanLy/HoaDon
        public ActionResult Index()
        {
            return View(_db.HOADONs.ToList());
        }

        // GET: QuanLy/HoaDon/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuanLy/HoaDon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanLy/HoaDon/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuanLy/HoaDon/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuanLy/HoaDon/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuanLy/HoaDon/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuanLy/HoaDon/Delete/5
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
