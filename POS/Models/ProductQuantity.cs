using System;

namespace POS.Models
{
    public class ProductQuantity
    {
        public int ProductQuantityId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
