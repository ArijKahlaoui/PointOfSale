using System;
using System.Collections.Generic;

namespace POS.Models
{
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
