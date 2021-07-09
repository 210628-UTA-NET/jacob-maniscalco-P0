using System.Collections.Generic;
namespace StoreDL
{
    public interface ICustomerRepository
    {
        bool AddCustomer(StoreModels.Customer p_customer);

        List<StoreModels.Customer> GetAllCustomers();
    }
}