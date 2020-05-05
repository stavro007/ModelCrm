using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.Options
{
    public class ProductOptions         // UI options to create a product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
