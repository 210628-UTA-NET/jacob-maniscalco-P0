using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using StoreModels;
namespace StoreDL 

{
    public class StoreRepository : IStoreRepository
    {
        private Entities.jacobmaniscalcoprojectContext _context;
        
        public StoreRepository(Entities.jacobmaniscalcoprojectContext p_context)
        {
            _context = p_context;
        }
        public List<StoreModels.StoreFront> getAllStoreFronts()
        { 
            throw new System.NotImplementedException();
        }
        public StoreModels.StoreFront getAStoreFront(StoreModels.StoreFront store)
        { 
            throw new System.NotImplementedException(); 
        }

        // Think about changing this to return a boolean instead, which can act as a flag for success
        public bool addAStoreFront(StoreModels.StoreFront store)
        {
           throw new System.NotImplementedException();
        }
    }
}