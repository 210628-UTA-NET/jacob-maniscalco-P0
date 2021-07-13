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
        
        public StoreModels.StoreFront getAStoreFront(int p_storeID)
        { 
            Entities.StoreFront store = _context.StoreFronts.First(store => store.StoreFrontId == p_storeID);

            return new StoreModels.StoreFront()
            {
                ID = store.StoreFrontId,
                Name = store.StoreFrontName,
                Address = store.StoreFrontAddress
            };
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

        public List<StoreModels.Order> GetOrders(int p_storeID)
        {
            
            List<int> orderIDs = new List<int>();

            List<StoreModels.Order> orders = (from order in _context.Orders  where (order.StoreFrontId == p_storeID)
                                              select new StoreModels.Order()
                                              {
                                                  Items = new List<OrderItem>(),
                                                  ID = order.OrderId,
                                                  Location = order.OrderLocation,
                                                  Price = (double) order.OrderPrice,
                                                  StoreID = (int) order.StoreFrontId

                                              }).ToList();
        foreach(StoreModels.Order order in orders)
        {
            orderIDs.Add(order.ID);
        }

        List<StoreModels.OrderItem> orderItems = 
                ( from orderItem in _context.OrderItems join product in _context.Products on 
                orderItem.OrderProductId equals product.ProductId
                where orderIDs.Contains(orderItem.OrderId)
                select new StoreModels.OrderItem()
                {
                    OrderID = orderItem.OrderId, 
                    Quantity = (int) orderItem.ItemQuantity,
                    Product = new Product()
                    {
                        Name = product.ProductName,
                        ID = product.ProductId,
                        Category = product.ProductCategory,
                        Description = product.ProductDescription,
                        Price = (double) product.ProductPrice
                    }
                }).ToList();
            
            foreach(Order order in orders)
            {
                foreach(OrderItem orderItem in orderItems)
                {
                    if(order.ID == orderItem.OrderID)
                    {
                        order.Items.Add(orderItem);
                    }
                }
            }
            return orders;
        }
    }
}