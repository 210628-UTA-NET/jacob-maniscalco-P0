using System;
using System.Collections.Generic;
using StoreDL;
using StoreModels;
namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new MainMenu();
            MenuType currMenu = MenuType.MainMenu;

           bool cond = true;

            while(cond)
            {
                Console.Clear();
                menu.menu();
                currMenu= menu.getChoice();
                

                switch(currMenu) {
                    case MenuType.MainMenu: 
                        menu = new MainMenu();
                        break;
                    case MenuType.CustomerMenu:
                        menu = new CustomerMenu();
                        break;
                    case MenuType.Exit:
                        cond = false;
                        break;
                }
            
            }


        }
    }
}
