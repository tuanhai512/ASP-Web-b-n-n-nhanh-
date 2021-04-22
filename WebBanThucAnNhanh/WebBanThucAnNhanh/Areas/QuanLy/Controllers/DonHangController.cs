using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanThucAnNhanh.Models;

namespace WebBanThucAnNhanh.Areas.QuanLy.Controllers
{
    public class DonHangController : Controller
    {
        QLThucAnNhanhEntities _db = new QLThucAnNhanhEntities();
        // GET: QuanLy/DonHang
        public ActionResult ShowMonAn()
        {
            if (Session["GioHang"] == null)
                return RedirectToAction("ShowMonAn","DonHang");
            GioHang _gioHang = Session["GioHang"] as GioHang;
            return View(_gioHang);
        }

        // GET: QuanLy/DonHang/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuanLy/DonHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanLy/DonHang/Create
        [HttpPost]
        public ActionResult Create(DATHANG collection)

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

        // GET: QuanLy/DonHang/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuanLy/DonHang/Edit/5
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

        // GET: QuanLy/DonHang/Delete/5
        public ActionResult Delete(int id)
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
