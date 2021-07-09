using System;
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
    }
}