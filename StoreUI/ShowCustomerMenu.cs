using System;
namespace StoreUI
{
    public class ShowCustomerMenu : IMenu
    {
        private static StoreModels.Customer _customer = new StoreModels.Customer();

        private StoreBL.CustomerBL _customerBL;

        public ShowCustomerMenu(StoreBL.CustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public MenuType getChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    Console.WriteLine("Customer ID: ");
                    string userID = Console.ReadLine();
                    StoreModels.Customer customer = _customerBL.GetCustomer(int.Parse(userID));
                    Console.WriteLine(customer.ToString());
                    Console.WriteLine("[0] Exit");
                    string exit = Console.ReadLine();
                    while (exit != "0")
                    {
                        Console.WriteLine("Incorrect Input");
                        Console.WriteLine("[0] Exit");
                        exit = Console.ReadLine();
                    }
                    return MenuType.AddCustomerMenu;

                case "0":
                    return MenuType.CustomerMenu;
                default:
                    Console.WriteLine("Incorrect Input");
                    return MenuType.ShowCustomerMenu;
            }
        }

        public void menu()
        {
            Console.WriteLine("[1] Enter the customer's ID.");
            Console.WriteLine("[0] Exit.");
        }
    }
}