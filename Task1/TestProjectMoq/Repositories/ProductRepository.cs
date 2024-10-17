using Microsoft.EntityFrameworkCore;
using TestProjectMoq.Contract;
using TestProjectMoq.Data;
using TestProjectMoq.Models;

namespace TestProjectMoq.Repositories;

public class ProductRepository:IProductRepository
{
    private readonly TaskDbContext _context;

    public ProductRepository(TaskDbContext context)
    {
        _context = context;

    }
    public async Task<IEnumerable<Product>> GetAllProductAsync()
    {
        return await _context.Products.ToListAsync();
    }
}