using System;
using System.Collections.Generic;
using System.Threading;
namespace StoreUI
{
    public class CreateOrderMenu : IMenu
    {
        private StoreBL.StoreBL _storeBL;
        private StoreBL.ProductBL _productBL;
        private StoreBL.CustomerBL _customerBL;

        public CreateOrderMenu(StoreBL.StoreBL p_storeBL, StoreBL.ProductBL p_productBL, StoreBL.CustomerBL p_customerBL)
        {
            _storeBL = p_storeBL;
            _productBL = p_productBL;
            _customerBL = p_customerBL;
        }
        public MenuType getChoice()
        {
            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                
                Console.WriteLine("Enter your customer ID: ");
                int userID = int.Parse(Console.ReadLine());
                Console.Clear();

                List<StoreModels.StoreFront> stores = _storeBL.GetAllStoreFronts();

                Console.WriteLine("|------------");
                Console.WriteLine("|   Stores   ");
                Console.WriteLine("|------------");
                foreach(StoreModels.StoreFront storeFront in stores)
                {
                    Console.WriteLine(storeFront);
                }

                Console.WriteLine("Enter the Store ID of the store you wish to order from.");
                userInput = Console.ReadLine();
                int storeID = int.Parse(userInput);
                Console.Clear();
                //Retrieve store Items and store Front object
                List<StoreModels.LineItem> storeItems = _storeBL.GetStoreInventory(storeID);
                StoreModels.StoreFront store = _storeBL.GetStoreFront(storeID);
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
                            double totalPrice = 0;
                            foreach(StoreModels.OrderItem item in customerOrder)
                            {
                                totalPrice += (item.Product.Price * item.Quantity);
                            }
                            foreach(StoreModels.OrderItem item in customerOrder)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine(String.Format("Total Price: {0:0.00}",totalPrice));
                            Console.WriteLine("Your order has been processed");
                            StoreModels.Order newOrder = new StoreModels.Order()
                            {
                                StoreID = storeID,
                                Items = customerOrder,
                                Location = store.Address,
                                Price = totalPrice
                            };

                            bool success =  _customerBL.AddOrder(newOrder, userID);
                            Thread.Sleep(5000);
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