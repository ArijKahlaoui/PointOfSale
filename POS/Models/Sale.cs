using System;
using System.Collections.Generic;

namespace POS.Models
{
    public class Sale
    {
        public Sale()
        {
            this.SaleDetails = new HashSet<SaleDetail>();
        }

        public int SaleId { get; set; }
        public string OrderNo { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string PaymentMethod { get; set; }
        public Nullable<double> TotalAmount { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> Status { get; set; }

        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
