using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanThucAnNhanh.Models
{
    public class GioHangItem
    {
        public MONAN _monan { get; set; }

        public int _quantity { get; set; }
    }
    public class GioHang
    {
        List<GioHangItem> items = new List<GioHangItem>();
        public IEnumerable<GioHangItem> Items
        {
            get { return items; }
        }
        public void Add_Product_Cart(MONAN mon, int _quan=1)
        {
            var item = Items.FirstOrDefault(s => s._monan.MAMONAN == mon.MAMONAN);
            if (item == null)
                items.Add(new GioHangItem
                {
                    _monan = mon,
                    _quantity = _quan
                });
            else
                item._quantity += _quan;
        }
        public int Total_quantity()
        {
            return items.Sum(s => s._quantity);
        }
        public decimal Total_money()
        {
            var total = items.Sum(s => s._quantity * s._monan.GIABAN);
            return (decimal)total;
       
        }
        public void Update_quantity(string id, int _new_quan)
        {
            var item = items.Find(s => s._monan.MAMONAN == id);
            if (item != null)
                item._quantity = _new_quan;
        }
        public void Remove_CartItem (string id)
        {
            items.RemoveAll(s => s._monan.MAMONAN == id);
        }
        public void ClearCart()
        {
            items.Clear();
        }
<<<<<<< HEAD
=======
        public int Total_Quantity()
        {
            return items.Sum(s => s._quantity);
        }
>>>>>>> teammate
    }
}