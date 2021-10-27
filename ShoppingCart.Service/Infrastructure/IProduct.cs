using ShoppingCart.Data.Model;
using System.Collections.Generic;

namespace ShoppingCart.Service.Infrastructure
{
    public interface IProduct
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        void Save();
    }
}
