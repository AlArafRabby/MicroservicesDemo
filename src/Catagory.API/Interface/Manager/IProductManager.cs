using Catagory.API.Models;
using MongoRepo.Interfaces.Manager;

namespace Catagory.API.Interface.Manager
{
    public interface IProductManager : ICommonManager<Product>
    {
        public List<Product> GetByCategory(string category);
    }
}
