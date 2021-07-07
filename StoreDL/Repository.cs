using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace StoreDL 

{
    public class Repository : IRepository
    {
        private Entities.jacobmaniscalcoprojectContext _context;
        
        public Repository(Entities.jacobmaniscalcoprojectContext p_context)
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
        public Boolean addAStoreFront(StoreModels.StoreFront store)
        {
           throw new System.NotImplementedException();
        }
    }
}