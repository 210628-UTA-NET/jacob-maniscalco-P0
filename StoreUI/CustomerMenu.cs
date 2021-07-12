using System;

namespace StoreUI
{
    public class CustomerMenu: IMenu
    {
        public void menu()
        {
            Console.WriteLine("Welcome to the customer menu.");
            Console.WriteLine("[5] To enter a new customer.");
            Console.WriteLine("[4] Show all customers.");
            Console.WriteLine("[3] Find a customer.");
            Console.WriteLine("[2] Make an order");
            Console.WriteLine("[1] Return to main menu.");
            Console.WriteLine("[0] To exit.");
        }

        public MenuType getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "5": 
                    return MenuType.AddCustomerMenu;
                case "4": 
                    return MenuType.ShowCustomersMenu;
                case "3":
                    return MenuType.ShowCustomerMenu;
                case "2":
                    return MenuType.CreateOrderMenu;
                case "1":
                    return MenuType.MainMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("That is not a valid input.");
                    return MenuType.CustomerMenu;
            }
        }
    }
}