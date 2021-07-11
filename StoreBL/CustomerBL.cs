using System.Collections.Generic;
using StoreModels;

namespace StoreBL
{
    public class CustomerBL : ICustomerBL
    {
        private StoreDL.ICustomerRepository _repo;

        public CustomerBL(StoreDL.ICustomerRepository p_repo)
        {
            _repo = p_repo;
        }
        public bool AddCustomer(Customer p_customer)
        {
            return _repo.AddCustomer(p_customer);
        }

        public List<StoreModels.Customer> GetAllCustomers()
        {
            return _repo.GetAllCustomers();
        }

        public StoreModels.Customer GetCustomer(int p_UserID)
        {
            return _repo.GetCustomer(p_UserID);
        }
    }
}