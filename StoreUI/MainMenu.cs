using System;

namespace StoreUI
{
    public class MainMenu : IMenu 
    {
        public void menu() 
        {
            Console.WriteLine("Welcome to the store");
            Console.WriteLine("[3] Enter store menu (add or view list of stores)");
            Console.WriteLine("[2] Enter the customer menu (add or list customers).");
            Console.WriteLine("[1] Enter Product Menu");
            Console.WriteLine("[0] Exit.");
        }

        public MenuType getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "3":
                    return MenuType.StoreMenu;
                case "2":
                    return MenuType.CustomerMenu;
                case "1":
                    return MenuType.ProductMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("That is not a valid input.");
                    return MenuType.MainMenu;
            }
        }
    }
}