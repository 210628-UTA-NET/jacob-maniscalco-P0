using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using StoreDL.Entities;
namespace StoreUI
{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType pMenu)
        {
            // Get the configuration from appsetting.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json")
                .Build();
            // Grabs connectionString from appsetting.json
            string connectionString = configuration.GetConnectionString("DBReference");

            DbContextOptions<jacobmaniscalcoprojectContext> options = new DbContextOptionsBuilder<jacobmaniscalcoprojectContext>()
                .UseSqlServer(connectionString)
                .Options;

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
                    return new addStoreFrontMenu(new StoreBL.StoreBL(new StoreDL.StoreRepository(new jacobmaniscalcoprojectContext(options))));
                case MenuType.ProductMenu:
                    return new ProductMenu();
                case MenuType.ShowProductMenu:
                    return new ProductMenu();
                case MenuType.ShowProductsMenu:
                    return new ShowProductsMenu(new StoreBL.ProductBL(new StoreDL.ProductRepository(new jacobmaniscalcoprojectContext(options))));
                default:
                    return new MainMenu();
            }
        }
    }
}