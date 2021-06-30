using System;

namespace StoreUI
{
    public class MainMenu : IMenu 
    {
        public void menu() 
        {
            Console.WriteLine("Welcome to the store");
            Console.WriteLine("[1] To enter the customer menu (add or list customers).");
            Console.WriteLine("[0] To exit.");
        }

        public MenuType getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    return MenuType.CustomerMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("That is not a valid input.");
                    return MenuType.MainMenu;
            }
        }
    }
}