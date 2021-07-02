using System;

namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        public void menu()
        {
            Console.WriteLine("[2]Enter a new store.");
            Console.WriteLine("[1] View a list of stores.");
            Console.WriteLine("[0] Return to main menu.");
        }

         public MenuType getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "2":
                    return MenuType.AddStoreFrontMenu;
                case "1":
                    return MenuType.StoreMenu;
                default:
                    return MenuType.StoreMenu;
            }
        }
    }
}