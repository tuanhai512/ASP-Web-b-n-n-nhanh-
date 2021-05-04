using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanThucAnNhanh.Models;

namespace WebBanThucAnNhanh.Areas.NhanVien.Controllers
{
    public class LoaiMonController : Controller
    {
        QLThucAnNhanhEntities _db = new QLThucAnNhanhEntities();
        // GET: NhanVien/LoaiMon
        public ActionResult Index()
        {
            return View(_db.LOAIs.ToList());
        }

        // GET: NhanVien/LoaiMon/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NhanVien/LoaiMon/Create
        public ActionResult Create()
        {
            LOAI loai = new LOAI();
            return View(loai);
        }

        // POST: NhanVien/LoaiMon/Create
        [HttpPost]
        public ActionResult Create(LOAI loai)
        {
            try
            {
                // TODO: Add insert logic here

                _db.LOAIs.Add(loai);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/LoaiMon/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NhanVien/LoaiMon/Edit/5
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

        // GET: NhanVien/LoaiMon/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NhanVien/LoaiMon/Delete/5
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
