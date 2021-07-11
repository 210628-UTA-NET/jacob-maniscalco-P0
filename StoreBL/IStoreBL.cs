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

        /// <summary>
        ///  Adds a StoreFront object to the database 
        /// </summary>
        /// <returns> Returns a boolean if the data was successfully added to the database</returns>
        Boolean addStoreFront(StoreModels.StoreFront p_store);

        /// <summary>
        /// Retrieves the inventory for a specific store
        /// </summary>
        /// <param name="p_storeID">The store ID </param>
        /// <returns>List of LineItems representing the store's inventory</returns>
        List<StoreModels.LineItem> GetStoreInventory(int p_storeID);
    }
}