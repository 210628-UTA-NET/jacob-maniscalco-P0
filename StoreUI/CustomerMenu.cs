using System;

namespace StoreUI
{
    public class CustomerMenu: IMenu
    {
        public void menu()
        {
            Console.WriteLine("Welcome to the customer menu.");
            Console.WriteLine("[0] Return to main menu.");
            Console.WriteLine("[0] To enter a new customer.");
            Console.WriteLine("[1] Output all current customers.");
            Console.WriteLine("[2] To exit.");
        }

        public string getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "0": 
                    return "MainMenu";
                case "1": 
                    return "CustomerMenu";
                default:
                    return "CustomerMenu";
            }
        }
    }
}