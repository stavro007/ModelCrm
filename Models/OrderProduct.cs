using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.Models
{
    public class OrderProduct
    {
        public int id { get; set; }

        public Product Product { get; set; }

        public Order Order { get; set; }
    }
}
