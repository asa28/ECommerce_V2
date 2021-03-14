using V2.DAL.Models;
using V2.DAL.Repositories;

namespace V2.BLL.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepo;

        public CategoryService(CategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }


        // implement Business Logic


        public Product Add()
        {
            return new Product();
        }

    }
}