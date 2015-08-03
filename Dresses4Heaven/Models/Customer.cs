using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dresses4Heaven.Models
{
    public class Customer : Person
    {

        /*public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }*/
        //public DateTime IntroductionDate { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Introduction Date")]
        public DateTime IntroDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        //public virtual ICollection<Event> Events { get; set; }
    }
}