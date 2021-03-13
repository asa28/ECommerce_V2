using V2.DAL.Interfaces;
using V2.DAL.Models;

namespace V2.BLL.Services
{
    public class ProductService
    {
        private readonly SqlRepo<Product> _ProductRepo;

        public ProductService(SqlRepo<Product> productRepo)
        {
            _ProductRepo = productRepo;
        }

        public Product Add()
        {
            // implement Business Logic 
            return new Product();
        }

    }
}