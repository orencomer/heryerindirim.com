using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace heryerindirim.com.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        [Required]
        [Display(Name ="Ad Soyad")]
        [StringLength(200)]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(200)]
        public char UserName { get; set; }
        [Required]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public char Password { get; set; }
        [Display(Name = "Ürün Sayısı")]
        [StringLength(200)]
        public int ProductCount { get; set; }
        [Display(Name = "Kampanya Sayısı")]
        [StringLength(200)]
        public int CampaignCount { get; set; }
        [Required]
        [Display(Name = "Logo")]
        public string Logo { get; set; }
    }
}
