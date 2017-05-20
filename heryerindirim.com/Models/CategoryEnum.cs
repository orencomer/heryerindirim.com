using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace heryerindirim.com.Models
{
    public enum CategoryEnum
    {
        [Display(Name = "Beyaz Eşya")]
        Furniture = 1,
        [Display(Name = "Market")]
        Markets = 2,
        [Display(Name = "Giyim")]
        Dress = 3,
        [Display(Name = "Elektronik")]
        Electronic = 4
    }
}
