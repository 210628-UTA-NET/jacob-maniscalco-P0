using System;
using System.Collections.Generic;

namespace StoreBL
{
    public interface IStoreBL
    {
        /// <summary>
        /// Retrieves all of the StoreFront objects stored in the database 
        /// </summary>
        /// <returns>Returns a list of StoreFront objects</returns>
        List<StoreModels.StoreFront> GetAllStoreFronts();
    }
}