using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Dresses4Heaven.Models
{

    public enum AccessLevel
    {
        A, B, C, D, F
    }

    public class Staff : Person
    {

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDate { get; set; }
        public AccessLevel? AccessLevel { get; set; }

        //public int StaffID { get; set; }
    }
}