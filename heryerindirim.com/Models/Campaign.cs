using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace heryerindirim.com.Models
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        [Required]
        [Display(Name = "Kampanya Adı")]
        [StringLength(200)]
        public string CampaignName { get; set; }
        [Required]
        [Display(Name = "Kampanya Tarihi")]
        public DateTime CampaignDate { get; set; }
        [Required]
        [Display(Name = "Kampanya Kategorisi")]
        [EnumDataType(typeof(Models.CategoryEnum))]
        public CategoryEnum CategoryEnum { get; set; }
        [Required]
        [Display(Name = "Kampanya Tarihleri")]
        public DateTime CampaignDates { get; set; }
        [Display(Name = "Kampanya Resmi")]
        public string CampaignImage { get; set; }
    }
}
