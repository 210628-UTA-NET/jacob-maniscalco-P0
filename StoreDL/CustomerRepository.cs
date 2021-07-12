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

        public StoreModels.Customer GetCustomer(int p_customerID)
        {
            var output =  _context.Customers.Find(p_customerID);

            return              
                new StoreModels.Customer()
                {
                     ID = output.CustomerId,
                        Name = output.CustomerName,
                        Address = output.CustomerAddress,
                        PhoneNumber = output.CustomerPhoneNumber
                };
        }

        public bool AddOrder(StoreModels.Order p_order, int p_userID)
        {
            StoreDL.Entities.Order customerOrder = new StoreDL.Entities.Order()
            {
                CustomerId = p_userID,
                OrderLocation = p_order.Location,
                OrderPrice = (decimal?) p_order.Price
            };
            
          _context.Orders.Add(customerOrder);
          _context.SaveChanges();
          

        foreach(OrderItem product in p_order.Items)
        {
            _context.OrderItems.Add(new StoreDL.Entities.OrderItem()
            {
                OrderId = customerOrder.OrderId,
                OrderProductId = product.Product.ID,
        
                ItemQuantity = product.Quantity
            });
        }

        _context.SaveChanges();

          Console.WriteLine("Customer Order ID: " + customerOrder.OrderId);
          return true;
        }
    }
}