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
    }
}