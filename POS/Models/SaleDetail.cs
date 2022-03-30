using System;

namespace POS.Models
{
    public partial class SaleDetail
    {
        public int SaleDetailId { get; set; }
        public Nullable<int> SaleId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<double> LineTotale { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> Status { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
