using System;
using System.Threading;

namespace StoreUI
{
    public class AddCustomerMenu : IMenu
    {
        private static StoreModels.Customer _newCustomer = new StoreModels.Customer();
        private StoreBL.ICustomerBL _customerBL;

        public AddCustomerMenu(StoreBL.ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        public MenuType getChoice()
        {
            string customerInput = Console.ReadLine();

            switch(customerInput)
            {
                case "4": 
                    Console.Write("Customer Name: ");
                    try
                    {
                        _newCustomer.Name = Console.ReadLine();
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Incorrect name format.");
                        Thread.Sleep(2000);
                    }
                    return MenuType.AddCustomerMenu;
                case "3":
                    Console.Write("Customer Address: ");
                    try
                    {
                        _newCustomer.Address = Console.ReadLine();
                    }
                    catch(System.Exception)
                    {
                        Console.WriteLine("Incorrect address format.");
                        Thread.Sleep(2000);
                    }
                    return MenuType.AddCustomerMenu;
                case "2":
                    Console.Write("Customer Phone Number: ");
                    try 
                    {
                        _newCustomer.PhoneNumber = Console.ReadLine();
                    }
                    catch(System.Exception)
                    {
                        Console.WriteLine("Incorrect phone number format.");
                        Thread.Sleep(2000);
                    }
                    return MenuType.AddCustomerMenu;
                case "1":
                    // Add logic to add customer to db
                    
                    _customerBL.AddCustomer(_newCustomer);
                    _newCustomer = new StoreModels.Customer();
                    return MenuType.AddCustomerMenu;
                case "0":
                    return MenuType.CustomerMenu;
                default:
                    return MenuType.AddCustomerMenu; 
            }
        }
        public void menu()
        {
            Console.WriteLine("---Add a customer---");
            Console.WriteLine($"[4] Name: {_newCustomer.Name}");
            Console.WriteLine($"[3] Address: {_newCustomer.Address}");
            Console.WriteLine($"[2] Phone Number: {_newCustomer.PhoneNumber}");
            Console.WriteLine("[1] Add Customer.");
            Console.WriteLine("[0] Exit to customer menu.");
        }
    }
}