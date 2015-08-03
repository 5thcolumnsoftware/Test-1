using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dresses4Heaven.Models
{
    public abstract class Person
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        [Required]
        [RegularExpression(@"^[A-Za-z0-9 ][A-Za-z0-9!@#$%^&* ]*$")]
        [StringLength(100, ErrorMessage = "Street cannot be longer than 100 characters.")]
        [Display(Name= "Street")]
        public string PersAddress1 { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z0-9 ][A-Za-z0-9!@#$%^&* ]*$")]
        [StringLength(100, ErrorMessage = "City cannot be longer than 100 characters.")]
        [Display(Name = "City/Town")]
        public string PersAddress2 { get; set; }

        [Required]
        [RegularExpression(@"^[A-Za-z0-9 ][A-Za-z0-9!@#$%^&* ]*$")]
        [StringLength(100, ErrorMessage = "County cannot be longer than 100 characters.")]
        [Display(Name = "County")]
        public string PersAddress3 { get; set; }
        
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        
        [Display(Name = "Phone Number")]
        public string PhoneNum { get; set; }
    }
}