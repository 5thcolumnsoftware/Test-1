using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Dresses4Heaven.Models
{
    public class Guuna
    {
        public string dressDesc { get; set; }
        public string DressNotes { get; set; }
        public int UnitPrice { get; set; }
        public int UKSize { get; set; }
        public int Shoulders { get; set; }
        public int Bust { get; set; }
        public int Waist { get; set; }
        public int Hips { get; set; }
        public int HollowToHem { get; set; }
        public int Sleeve { get; set; }
        public int Trail { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FittingDate { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
    }
}