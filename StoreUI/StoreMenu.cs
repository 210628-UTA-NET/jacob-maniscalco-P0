using System;

namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        public void menu()
        {
            Console.WriteLine("[3]Enter a new store.");
            Console.WriteLine("[2] View a list of stores.");
            Console.WriteLine("[1] View store inventory");
            Console.WriteLine("[0] Return to main menu.");
        }

         public MenuType getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "3":
                    return MenuType.AddStoreFrontMenu;
                case "2":
                    return MenuType.ShowStoresMenu;
                case "1":
                    return MenuType.StoreInventoryMenu;
                case "0":
                    return MenuType.MainMenu;
                default:
                    return MenuType.StoreMenu;
            }
        }
    }
}