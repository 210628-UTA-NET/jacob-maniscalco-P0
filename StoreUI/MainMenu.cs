using System;

namespace StoreUI
{
    public class MainMenu : IMenu 
    {
        public void menu() 
        {
            Console.WriteLine("Welcome to the store");
            //Console.WriteLine("[0] To return to the main menu.");
            Console.WriteLine("[0] To enter the customer menu (add or list customers).");
            Console.WriteLine("[1] To exit.");
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
                    return "Exit";
            }
        }
    }
}