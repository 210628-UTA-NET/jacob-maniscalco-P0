namespace StoreUI
{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType pMenu)
        {
            switch(pMenu)
            {
                case MenuType.MainMenu:
                    return new MainMenu();
                case MenuType.CustomerMenu:
                    return new CustomerMenu();
                case MenuType.AddCustomerMenu:
                    return new AddCustomerMenu();
                case MenuType.StoreMenu:
                    return new StoreMenu();
                case MenuType.AddStoreFrontMenu:
                    return new addStoreFrontMenu();
                default:
                    return new MainMenu();
            }
        }
    }
}