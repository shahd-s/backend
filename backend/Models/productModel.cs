using System;
using System.Collections.Generic;

namespace backend.Models
{
    //Representing a customer and their items and order for displaying in the view
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
