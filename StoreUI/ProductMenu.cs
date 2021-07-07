using System;
namespace StoreUI
{
    public class ProductMenu : IMenu
    {
        public MenuType getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "2":
                    return MenuType.GetAllProductsMenu;
                case "1":
                    return MenuType.GetProductMenu;
                case "0":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("Not a valid input");
                    return MenuType.ProductMenu;
            }
        }

        public void menu()
        {
            Console.WriteLine("[2] Get All Products.");
            Console.WriteLine("[1] Get Specific Product.");
            Console.WriteLine("[0] Exit.");
        }
    }
}