using System.Collections.Generic;
namespace StoreDL
{
    public interface IProductRepository
    {
        List<StoreModels.Product> getAllProducts();

        StoreModels.Product getProduct(StoreModels.Product p_product);

        bool addCustomer(StoreModels.Product p_product);
    }
}