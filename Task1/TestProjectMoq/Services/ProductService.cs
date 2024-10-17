using TestProjectMoq.Contract;
using TestProjectMoq.Models;

namespace TestProjectMoq.Services;

public class ProductService
{
    private readonly IProductRepository _accountRepository;

    public ProductService(IProductRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _accountRepository.GetAllProductAsync();
    }
}