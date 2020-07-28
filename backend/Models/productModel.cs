using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class productModel
    {
        public productModel()
        {
        }
        public User cust { get; set; }
        public List<Product> products { get; set; }
        public IEnumerable<ProductOrder> productorders { get; set; }
    }
}

 
