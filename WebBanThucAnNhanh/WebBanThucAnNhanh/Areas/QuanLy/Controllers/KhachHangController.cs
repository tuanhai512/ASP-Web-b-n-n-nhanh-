using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanThucAnNhanh.Models;

namespace WebBanThucAnNhanh.Areas.QuanLy.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: QuanLy/KhachHang

        QLThucAnNhanhEntities database = new QLThucAnNhanhEntities();
        public ActionResult Index()
        {
            return View(database.KHACHHANGs.ToList());
        }

        // GET: QuanLy/KhachHang/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuanLy/KhachHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanLy/KhachHang/Create
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

        // GET: QuanLy/KhachHang/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuanLy/KhachHang/Edit/5
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

        // GET: QuanLy/KhachHang/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuanLy/KhachHang/Delete/5
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
