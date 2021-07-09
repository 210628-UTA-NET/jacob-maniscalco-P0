using System;
using System.Collections.Generic;
using StoreModels;
using System.Linq;
namespace StoreDL
{
    public class CustomerRepository : ICustomerRepository
    {
        private Entities.jacobmaniscalcoprojectContext _context;

        public CustomerRepository(Entities.jacobmaniscalcoprojectContext p_context)
        {
            _context = p_context;
        }
        public bool AddCustomer(Customer p_customer)
        {
            _context.Customers.Add(new StoreDL.Entities.Customer{
                CustomerId = p_customer.ID,
                CustomerName = p_customer.Name,
                CustomerAddress = p_customer.Address,
                CustomerPhoneNumber = p_customer.PhoneNumber
            });
            _context.SaveChanges();
            return true;
        }

        public List<StoreModels.Customer> GetAllCustomers()
        {
            return _context.Customers.Select(
                customer =>
                    new StoreModels.Customer()
                    {
                        ID = customer.CustomerId,
                        Name = customer.CustomerName,
                        Address = customer.CustomerAddress,
                        PhoneNumber = customer.CustomerPhoneNumber
                    }
            ).ToList();
        }
    }
}