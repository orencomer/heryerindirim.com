using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace heryerindirim.com.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        [Required]
        [Display(Name = "Firma Adı")]
        [StringLength(200)]
        public string CompanyName { get; set; }
        [Required]
        [Display(Name = "Firma Adresi")]
        public string CompanyAddress { get; set; }
        [Required]
        [Display(Name = "Firma Telefonu")]
        [StringLength(200)]
        public string CompanyPhone { get; set; }
        [Required]
        [Display(Name ="Firma Kategorisi")]
        [EnumDataType(typeof(Models.CategoryEnum))]
        public CategoryEnum CategoryEnum { get; set; }
        [Display(Name = "Logo")]
        public string Logo { get; set; }
    }
}
