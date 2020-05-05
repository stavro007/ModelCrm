using ModelCrm.CrmDbContext;
using ModelCrm.Models;
using ModelCrm.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.Services
{
    public class ProductCrud
    {
        public Product CreateProduct(ProductOptions productOptions)
        {
            Product product = new Product
            {
                Code = productOptions.Code,
                Name = productOptions.Name,
                Description = productOptions.Description,
                Price = productOptions.Price,
                Quantity = productOptions.Quantity
            };
            
            using CrmAppDbContext dbContext = new CrmAppDbContext();  // to create a link with database 
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return product;
        }
    }
}
