using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Pass not emty")]
        public string _pass { get; set; }
        [Display(Name = "Email ")]
        [Required(ErrorMessage = "Email not emty")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string _email { get; set; }
        [Required(ErrorMessage = "phone not emty")]
        public string _phone { get; set; }
        [Required(ErrorMessage = "Name not emty")]
        public string _tenkh { get; set; }
        [Display(Name = "Địa chỉ ")]
        [Required(ErrorMessage = "Address not emty")]
        public string _diachi { get; set; }

        [NotMapped]
        public string ErrorRegister { get; set; }
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
        public int Total_Quantity()
        {
            return items.Sum(s => s._quantity);
        }
    }
}