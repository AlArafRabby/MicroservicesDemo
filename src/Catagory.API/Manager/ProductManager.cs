using Catagory.API.Interface.Manager;
using Catagory.API.Models;
using Catagory.API.Repository;
using MongoRepo.Manager;

namespace Catagory.API.Manager
{
    public class ProductManager : CommonManager<Product>, IProductManager
    {
        public ProductManager() : base(new ProductRepository())
        {
        }

        public List<Product> GetByCategory(string category)
        {
            return GetAll(c => c.Category == category).ToList();
        }
    }
}
