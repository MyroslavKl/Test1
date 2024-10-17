using TestProjectMoq.Models;

namespace TestProjectMoq.Contract;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductAsync();
}