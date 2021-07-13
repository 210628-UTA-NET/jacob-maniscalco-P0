using System;
using System.Collections.Generic;
namespace StoreUI
{
    public class ShowCustomerOrders : IMenu
    {

        private StoreBL.CustomerBL _customerBL;

        public ShowCustomerOrders(StoreBL.CustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public MenuType getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    Console.WriteLine("Enter your user ID: ");
                    int userID = int.Parse(Console.ReadLine());
                    Console.Clear();
                    List<StoreModels.Order> customerOrders = _customerBL.GetOrders(userID);
                    foreach(StoreModels.Order order in customerOrders)
                    {
                        Console.WriteLine(order);
                    }
                    Console.WriteLine("Enter 1 to exit.");
                    string exitInput = Console.ReadLine();
                    if (exitInput == "1")
                        return MenuType.CustomerMenu;
                    else return MenuType.ShowCustomerOrders;

                case "0":
                    return MenuType.CustomerMenu;
                default: 
                    return MenuType.CustomerMenu;
            }
        }

        public void menu()
        {
            Console.WriteLine("[1] View your order history.");
            Console.WriteLine("[0] Exit");
        }
    }
}