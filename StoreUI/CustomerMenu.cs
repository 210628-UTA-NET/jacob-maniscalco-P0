using System;

namespace StoreUI
{
    public class CustomerMenu: IMenu
    {
        public void menu()
        {
            Console.WriteLine("Welcome to the customer menu.");
            Console.WriteLine("[1] To enter a new customer.");
            Console.WriteLine("[2] Return to main menu.");
            Console.WriteLine("[0] To exit.");
        }

        public MenuType getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1": 
                    return MenuType.AddCustomerMenu;
                case "2": 
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