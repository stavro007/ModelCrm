using ModelCrm.Models;
using ModelCrm.Options;
using ModelCrm.Services;
using System;

namespace ModelCrm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CustomerOptions custOpt = new CustomerOptions
            {
                FirstName = "Dimitris",
                LastName = "Dimitriou",
                Address = "Athens",
                VatNumber = "012345678",
                Email = "dimitriou@mail.com",
                Phone = "210-74 000 111",
                Dob = new DateTime(1970, 12, 31),
            };

            CustomerCrud custCrud = new CustomerCrud();  

            Customer customer = custCrud.CreateCustomer(custOpt);

            Console.WriteLine($"Id = {customer.Id} " +
                $"FirstName= {customer.FirstName}");
            */

            ProductOptions productopt = new ProductOptions
            {
                Code = "randomcode",
                Name = "acer_laptop",
                Description = "New Model with i7 intel processor",
                Price = 567.5M,
                Quantity = 50,
            };

            ProductCrud productCrud = new ProductCrud();
            Product product = productCrud.CreateProduct(productopt);

            Console.WriteLine($"Id = {product.Id} " +
                $"FirstName= {product.Name}");


            //Console.WriteLine("Id = " 
            //    + customer.Id  
            //    + " FirstName= "
            //    + customer.FirstName);





        }
    }
}
