using ShoppingCart.Data;
using System.Collections.Generic;

namespace ShoppingCart.Service.Infrastructure
{
    public interface ICategory
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void InsertCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        void Save();
    }
}
