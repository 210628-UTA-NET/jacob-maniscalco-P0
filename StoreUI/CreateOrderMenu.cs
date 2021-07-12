using System;
using System.Collections.Generic;
namespace StoreUI
{
    public class CreateOrderMenu : IMenu
    {
        private StoreBL.StoreBL _storeBL;
        private StoreBL.ProductBL _productBL;

        public CreateOrderMenu(StoreBL.StoreBL p_storeBL, StoreBL.ProductBL p_productBL)
        {
            _storeBL = p_storeBL;
            _productBL = p_productBL;
        }
        public MenuType getChoice()
        {
            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                int userID = int.Parse(userInput);
                Console.Clear();

                List<StoreModels.StoreFront> stores = _storeBL.GetAllStoreFronts();

                Console.WriteLine("|------------");
                Console.WriteLine("|   Stores   ");
                Console.WriteLine("|------------");
                foreach(StoreModels.StoreFront store in stores)
                {
                    Console.WriteLine(store);
                }

                Console.WriteLine("Enter the Store ID of the store you wish to order from.");
                userInput = Console.ReadLine();
                int StoreID = int.Parse(userInput);
                Console.Clear();
                List<StoreModels.LineItem> storeItems = _storeBL.GetStoreInventory(StoreID);
                
                List<StoreModels.OrderItem> customerOrder = new List<StoreModels.OrderItem>();

                bool cond = true;
                while (cond)
                {
                    Console.WriteLine("Enter 1 to order an item. 0 to complete your order.");
                    string ProductInput = Console.ReadLine();
                    switch (ProductInput)
                    {
                        case "1": 
                        {
                            Console.Clear();
                            Console.WriteLine("|-----------------");
                            Console.WriteLine("|   Store Items   ");
                            Console.WriteLine("|-----------------\n");
                            foreach(StoreModels.LineItem item in storeItems)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine("Enter the item ID: ");
                            ProductInput = Console.ReadLine();
                            int id = int.Parse(ProductInput);
                            StoreModels.Product orderItem = _productBL.GetProduct(id);
                            Console.Write("Number of Items: ");
                            int itemQuantity = int.Parse(Console.ReadLine());


                            customerOrder.Add(
                                new StoreModels.OrderItem()
                                {
                                    Product = orderItem,
                                    Quantity = itemQuantity
                                }
                            );
                            Console.Clear();
                            Console.WriteLine("|-----------------------|");
                            Console.WriteLine("|-----Current Order-----|");
                            Console.WriteLine("|-----------------------|\n");
                            foreach(StoreModels.OrderItem item in customerOrder)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                        case "0":
                            StoreModels.Order newOrder = new StoreModels.Order()
                            {
                                
                            };
                            cond = false;
                            break;
                            
                        default:
                            break;
                    }
                }
                return MenuType.CustomerMenu;
            case "0":
                return MenuType.CustomerMenu;
            default: 
                return MenuType.CreateOrderMenu;
            }
        }

        public void menu()
        {
            Console.WriteLine("[1] Create An Order.");
            Console.WriteLine("[0] Exit");
        }
    }
}