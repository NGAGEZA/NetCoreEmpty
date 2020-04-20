using System;
using System.ComponentModel.DataAnnotations;

namespace CPSProject.Models.db
{
    public class V_SHIP_BLUE_BOX_WITH_INCMG
    {
        [Display(Name = "DATE")]
        public DateTime Date1 { get; set; }
        [Display(Name = "TIME")]
        public string Time1 { get; set; }
        [Key]
        public string LotNo { get; set; }
        public string ROHM_Model_Name { get; set; }
        public int QTY { get; set; }
        public string Type_Name { get; set; }
        public int? BOX { get; set; }
        [Display(Name = "PRODUCTCODE")]
        public string PDCD { get; set; }
    }
}
