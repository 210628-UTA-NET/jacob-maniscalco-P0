using System;

namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new MainMenu();
            String currMenu = "MainMenu";

           bool cont = true;

            while(cont)
            {
                menu.menu();
                currMenu= menu.getChoice();
                

                switch(currMenu) {
                    case "MainMenu": 
                        menu = new MainMenu();
                        break;
                    case "CustomerMenu":
                        menu = new CustomerMenu();
                        break;
                    default:
                        cont = false;
                        break;
                }
            
            }


        }
    }
}
