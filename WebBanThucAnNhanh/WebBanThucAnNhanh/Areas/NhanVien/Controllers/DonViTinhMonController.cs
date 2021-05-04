using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanThucAnNhanh.Models;

namespace WebBanThucAnNhanh.Areas.NhanVien.Controllers
{
    public class DonViTinhMonController : Controller
    {
        QLThucAnNhanhEntities _db = new QLThucAnNhanhEntities();
        // GET: NhanVien/DonViTinhMon
        public ActionResult Index()
        {
            return View(_db.DONVITINHs.ToList());
        }

        // GET: NhanVien/DonViTinhMon/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NhanVien/DonViTinhMon/Create
        public ActionResult Create()
        {
            DONVITINH donvitinh = new DONVITINH();
            return View(donvitinh);
        }

        // POST: NhanVien/DonViTinhMon/Create
        [HttpPost]
        public ActionResult Create(DONVITINH donvitinh)
        {
            try
            {
                // TODO: Add insert logic here

                _db.DONVITINHs.Add(donvitinh);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/DonViTinhMon/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NhanVien/DonViTinhMon/Edit/5
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

        // GET: NhanVien/DonViTinhMon/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NhanVien/DonViTinhMon/Delete/5
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
