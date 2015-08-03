using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dresses4Heaven.Models
{

    public enum EventType
    {
        A, B, C, D, F
    }
    public class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }
        public string Title { get; set; }
        public EventType? EventType { get; set; }
        //public string Location { get; set; }


        [RegularExpression(@"^[A-Za-z0-9 ][A-Za-z0-9!@#$%^&* ]*$")]
        [Required]
        [StringLength(100, ErrorMessage = "Street cannot be longer than 100 characters.")]
        public string EventAddress1 { get; set; }

        [RegularExpression(@"^[A-Za-z0-9 ][A-Za-z0-9!@#$%^&* ]*$")]
        [Required]
        [StringLength(100, ErrorMessage = "City cannot be longer than 100 characters.")]
        public string EventAddress2 { get; set; }

        [RegularExpression(@"^[A-Za-z0-9 ][A-Za-z0-9!@#$%^&* ]*$")]
        [Required]
        [StringLength(100, ErrorMessage = "County cannot be longer than 100 characters.")]
        public string EventAddress3 { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EventDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}