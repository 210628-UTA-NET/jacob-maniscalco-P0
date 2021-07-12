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

        public List<StoreModels.LineItem> GetStoreInventory(int p_storeID)
        {
            //What will be returned
            List<StoreModels.LineItem> LineItems = new List<StoreModels.LineItem>();

            // List of Entities.LineItem objects that match supplied store ID
            var EntityItems = _context.LineItems.Where(item => item.StoreFrontId == p_storeID);
            
            //Creates a List of product IDs to later search the db
            List<int> productIDs = new List<int>();
            foreach(Entities.LineItem item in EntityItems)
            {
                productIDs.Add((int) item.LineItemProductId);
            }  
            // db search for products with IDs from the productIDs List 
            var ProductItems = _context.Products.Where(item => productIDs.Contains(item.ProductId));
            

            List<StoreModels.Product> products = new List<StoreModels.Product>();
            foreach(Entities.Product product in ProductItems)
            {
                products.Add(
                    new Product()
                    {
                        ID = product.ProductId,
                        Name = product.ProductName,
                        Description = product.ProductDescription,
                        Category = product.ProductCategory,
                        Price = (double) product.ProductPrice
                    }
                );
            }
            int i = 0;
            foreach(Entities.LineItem item in EntityItems)
            {
                LineItems.Add(
                    new LineItem()
                    {
                        Product = products.ElementAt(i),
                        Quantity = item.ItemQuantity.Value
                    }
                );
                i++;
            }
            _context.SaveChanges();
        return LineItems;
        }
    }
}