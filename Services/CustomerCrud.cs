using ModelCrm.CrmDbContext;
using ModelCrm.Models;
using ModelCrm.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelCrm.Services
{
    public class CustomerCrud
    {
        public Customer CreateCustomer(CustomerOptions customerOptions)
        {
            Customer customer = new Customer
            {
                FirstName = customerOptions.FirstName,
                LastName = customerOptions.LastName,
                Phone = customerOptions.Phone,
                Email = customerOptions.Email,
                VatNumber = customerOptions.VatNumber,
                Address = customerOptions.Address,
                Dob = customerOptions.Dob,
                CreatedDate = DateTime.Now,
                IsActive = true,
                TotalGross = 0M
            };
            
            using CrmAppDbContext dbContext = new CrmAppDbContext();
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
            return customer;
        }

    }
}
