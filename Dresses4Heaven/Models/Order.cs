using System;
using System.ComponentModel.DataAnnotations;


namespace Dresses4Heaven.Models
{
    public enum OrderType
    {
        A, B, C, D, F
    }

    public enum PaymentType
    {
        A, B, C, D, F
    }

    public class Order
    {
        public int OrderID { get; set; }
        public int EventID { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
        public OrderType? OrderType { get; set; }

        public PaymentType? PaymentType { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DeadlineDate { get; set; }

        public int OrderPrice { get; set; }
        public int DepositAmt { get; set; }
        public bool Depositpaid { get; set; }
        public int AmntDue { get; set; }
        public bool PaidInFull { get; set; }

        public virtual Event Event { get; set; }
        public virtual Customer Customer { get; set; }
        //public virtual Guuna Customer { get; set; }
    }
}