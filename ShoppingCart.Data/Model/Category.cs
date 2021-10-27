using ShoppingCart.Data.Model;
using System.Collections.Generic;

namespace ShoppingCart.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductCategory> Products { get; set; }
    }
}
