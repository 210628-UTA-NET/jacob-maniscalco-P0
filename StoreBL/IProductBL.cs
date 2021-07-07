using System.Collections.Generic;
namespace StoreBL
{
    public interface IProductBL
    {
        List<StoreModels.Product> GetAllProducts();

        StoreModels.Product GetProduct(StoreModels.Product p_product);

        bool addProduct(StoreModels.Product p_product);
    }
}