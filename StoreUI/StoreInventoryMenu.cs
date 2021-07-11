using System;
using System.Collections.Generic;
namespace StoreUI
{
    public class StoreInventoryMenu : IMenu
    {
        private StoreBL.IStoreBL _storeBL;

        public StoreInventoryMenu(StoreBL.IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }
        public MenuType getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    Console.WriteLine("Store ID: ");
                    string storeID = Console.ReadLine();
                    List<StoreModels.LineItem> items = new List<StoreModels.LineItem>();
                    items = _storeBL.GetStoreInventory(int.Parse(storeID));
                    
                    foreach(StoreModels.LineItem item in items)
                    {
                        Console.WriteLine("------");
                        Console.WriteLine(item);
                        Console.WriteLine("------");
                    }

                    string exit = Console.ReadLine();
                    while (exit != "0")
                    {
                        Console.WriteLine("Incorrect Input");
                        Console.WriteLine("[0] Exit");
                        exit = Console.ReadLine();
                    }

                    return MenuType.StoreInventoryMenu;

                case "0":
                    return MenuType.StoreMenu;
                default:
                    return MenuType.StoreInventoryMenu;
            }
        }

        public void menu()
        {
            Console.WriteLine("[1] Enter Store ID");
            Console.WriteLine("[0] Exit");
        }
    }
}