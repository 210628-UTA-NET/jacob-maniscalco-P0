using System;
using System.Collections.Generic;

namespace StoreBL
{
    public interface ICustomerBL
    {
        /// Add documentation
        bool AddCustomer(StoreModels.Customer p_customer);

        List<StoreModels.Customer> GetAllCustomers();
    }
}