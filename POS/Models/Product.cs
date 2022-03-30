using System;
using System.Collections.Generic;

namespace POS.Models
{
    public class Product
    {
        public Product()
        {
            this.ProductQuantities = new HashSet<ProductQuantity>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public int Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<ProductQuantity> ProductQuantities { get; set; }
    }
}
