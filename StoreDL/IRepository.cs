using System;
using System.Collections.Generic;


namespace StoreDL
{
    public interface IRepository 
    {
        /// <summary>
        /// Retrieves all storeFront fronts from the database
        /// </summary>
        /// <returns>A list of StoreFront objects </returns>
        List<StoreModels.StoreFront> getAllStoreFronts();

        /// <summary>
        /// Retrieves a specific storeFront object from the database
        /// </summary>
        /// <param name="store"> A storeFront object to be retrieved</param>
        /// <returns>A store object from the database</returns>
        StoreModels.StoreFront getAStoreFront(StoreModels.StoreFront store);

        /// <summary>
        /// Will insert a storeFront object into the database
        /// </summary>
        /// <param name="store">The storeFront object the user wishes to insert into the database</param>
        /// <returns>A storeFront object that has just been created</returns>
        Boolean addAStoreFront(StoreModels.StoreFront store);


    }
}