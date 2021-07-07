using System;
using System.Collections.Generic;
using System.Linq;
using StoreModels;

namespace StoreDL
{
    public class ProductRepository : IProductRepository
    {
        private Entities.jacobmaniscalcoprojectContext _context;
        public bool addCustomer(Product p_product)
        {
            throw new System.NotImplementedException();
        }

        public List<Product> getAllProducts()
        {
            return _context.Products.Select(
                product =>
                    new StoreModels.Product()
                    {
                        ID = product.ProductId,
                        Name = product.Name,
                        Description = product.Description,
                        Price = (double) product.Price,
                        Category = product.Category
                    }
            ).ToList();
        }

        public Product getProduct(Product p_product)
        {
            throw new System.NotImplementedException();
        }
    }
}