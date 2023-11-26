using Catagory.API.Context;
using Catagory.API.Interface.Repositorty;
using Catagory.API.Models;
using MongoRepo.Repository;

namespace Catagory.API.Repository
{
    public class ProductRepository : CommonRepository<Product>, IProductRepository
    {
        public ProductRepository() : base(new CatalogDbContext())
        {
        }
    }
}
