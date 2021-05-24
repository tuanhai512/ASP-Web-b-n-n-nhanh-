using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using WebBanThucAnNhanh.Models;

namespace WebBanThucAnNhanh.Controllers
{
    public class GioHangController : Controller
    {
        QLThucAnNhanhEntities _db = new QLThucAnNhanhEntities();
        // GET: GioHang
        public GioHang GetGioHang()
        {
            GioHang giohang = Session["GioHang"] as GioHang;
            if(giohang == null || Session["GioHang"] == null)
            {
                giohang = new GioHang();
                Session["GioHang"] = giohang;
            }
            return giohang;
        }
        public ActionResult AddToCart(string id)
        {
            var monan = _db.MONANs.SingleOrDefault(s => s.MAMONAN == id);
            if(monan!=null)
            {
                GetGioHang().Add_Product_Cart(monan);
            }
            return RedirectToAction("ShowToCart", "GioHang");
        }
        //Trang giỏ hàng
        public ActionResult ShowToCart()
        {
            if (Session["GioHang"] == null)
                return RedirectToAction("ShowToCart", "GioHang");
            GioHang giohang = Session["GioHang"] as GioHang;
            return View(giohang);
        }
        public ActionResult Update_Quantity_Cart(FormCollection form)
        {
            GioHang giohang = Session["GioHang"] as GioHang;
            string ma_monan = form["MA_MONAN"];
            int quantity = int.Parse(form["Quantity"]);
            giohang.Update_quantity(ma_monan, quantity);
            return RedirectToAction("ShowToCart", "GioHang");
        }
        public ActionResult RemoveCart(string id)
        {
            GioHang giohang = Session["GioHang"] as GioHang;
            giohang.Remove_CartItem(id);
            return RedirectToAction("ShowToCart", "GioHang");
        }
        public PartialViewResult BagCart()
        {
            int _t_item = 0;
            GioHang giohang = Session["GioHang"] as GioHang;
            if(giohang != null)
            {
                _t_item = giohang.Total_Quantity();
            }
            ViewBag.infoGioHang = _t_item;
            return PartialView("BagCart");
        }
        public ActionResult CheckoutSuccess()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            var GioHang = GetGioHang();
            if (GioHang.Total_quantity() == 0)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
        [HttpPost]
        public ActionResult Checkout(DIACHIGH model)
        {
            var giohang = GetGioHang();
            if (giohang.Total_quantity() == 0)
            {
                ModelState.AddModelError("", "Gio Hang ko duoc de trong");
            }
            if (ModelState.IsValid)
            {
                //DIACHIGIAOHANG
                var diachigh = new DIACHIGH()
                {
                    HOTEN = model.HOTEN,
                    SDT = model.SDT,
                    SONHA = model.SONHA,
                    PHUONG = model.PHUONG,
                    QUAN = model.QUAN,
                    //MAKHACHHANG = model.
                };
                _db.DIACHIGHs.Add(diachigh);
                _db.SaveChanges();

                //DATHANG
                var dathang = new DATHANG()
                {
                    MADIACHI = diachigh.MADIACHI,
                    NGAY = DateTime.Now,
                    TONGTIEN = giohang.Total_money(),

                };
                _db.DATHANGs.Add(dathang);
                _db.SaveChanges();

                //CT DAT HANG
                var ctdathang = new List<CT_MONAN_DATHANG>();
                foreach (var item in giohang.Items)
                {
                    var detail = new CT_MONAN_DATHANG()
                    {
                        MAMONAN = item._monan.MAMONAN,
                        MADATHANG = dathang.MADATHANG,
                        SOLUONG = item._quantity,
                        GIABAN = item._monan.GIABAN,
                    };
                    ctdathang.Add(detail);
                }
                foreach (var detail in ctdathang)
                {
                    _db.CT_MONAN_DATHANG.Add(detail);
                }
                _db.SaveChanges();

                return RedirectToAction("CheckoutSuccess");
            }
            else
            {
                ModelState.AddModelError("", "Vui Long nhap du du lieu.");
            }
            return View(model);
        }
    }
}