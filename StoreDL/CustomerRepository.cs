
using StoreModels;

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
    }
}