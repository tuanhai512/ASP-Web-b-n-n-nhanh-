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
        QLThucAnNhanhEntities9 _db = new QLThucAnNhanhEntities9();
        // GET: GioHang
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if(cart == null || Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        public ActionResult AddToCart(string id)
        {
            var monan = _db.MONANs.SingleOrDefault(s => s.MAMONAN == id);
            if(monan!=null)
            {
                GetCart().Add(monan);
            }
            return RedirectToAction("ShowToCart", "GioHang");
        }
        //Trang giỏ hàng
        public ActionResult ShowToCart()
        {
            if (Session["Cart"] == null)
                return RedirectToAction("ShowToCart", "GioHang");
            Cart cart = Session["Cart"] as Cart;
            return View(cart);
        }
        public ActionResult Update_Soluong_Cart(FormCollection form)
        {
            Cart cart = Session["Cart"] as Cart;
            string ma_monan = form["MA_MONAN"];
            int soluong = int.Parse(form["Soluong"]);
            cart.Update_Soluong_Shopping(ma_monan, soluong);
            return RedirectToAction("ShowToCart", "GioHang");
        }
        public ActionResult RemoveCart(string id)
        {
            Cart cart = Session["Cart"] as Cart;
            cart.Remove_CartItem(id);
            return RedirectToAction("ShowToCart", "GioHang");
        }
    }
}