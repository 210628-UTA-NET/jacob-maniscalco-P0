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
            return _context.StoreFronts.Select(
                store =>
                    new StoreModels.StoreFront()
                    {
                        ID = store.StoreFrontId,
                        Name = store.StoreFrontName,
                        Address = store.StoreFrontAddress
                    }
                ).ToList();
        }
        
        public StoreModels.StoreFront getAStoreFront(StoreModels.StoreFront store)
        { 
            throw new System.NotImplementedException(); 
        }

        // Think about changing this to return a boolean instead, which can act as a flag for success
        public bool addAStoreFront(StoreModels.StoreFront p_store)
        {
           _context.StoreFronts.Add(new StoreDL.Entities.StoreFront{
               StoreFrontId = p_store.ID,
               StoreFrontName = p_store.Name,
               StoreFrontAddress = p_store.Address
           });

           _context.SaveChanges();
           return true;
        }
    }
}