using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace heryerindirim.com.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Ürün Fiyatı")]
        [StringLength(200)]
        public int ProductPrice { get; set; }
        [Required]
        [Display(Name = "İndirimli Ürün Fiyatı")]
        [StringLength(200)]
        public int DiscountedPrice { get; set; }
        [Display(Name = "Stok Adeti")]
        [StringLength(200)]
        public int ProductStockCount { get; set; }
        [Required]
        [Display(Name = "Ürün Kategorisi")]
        [EnumDataType(typeof(Models.CategoryEnum))]
        public CategoryEnum CategoryEnum { get; set; }
        [Required]
        [Display(Name = "İndirim Tarihi")]
        public DateTime DiscountDate { get; set; }
        [Display(Name = "Ürün Resmi")]
        public string ProductImage { get; set; }
    }
}
