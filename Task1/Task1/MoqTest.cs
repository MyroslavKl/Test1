using Moq;
using TestProjectMoq.Contract;
using TestProjectMoq.Models;
using TestProjectMoq.Services;

namespace Task1;

public class MoqTest
{
    [Fact]
    public async Task GetAllAccountsAsync_ReturnsListOfAccounts()
    {
        var mockRepo = new Mock<IProductRepository>();
        var mockProducts = new List<Product>
        {
            new Product { Id = 1, Name = "Apple", Count = 3 },
            new Product { Id = 2, Name = "Pencil", Count = 1}
        };
        
        mockRepo.Setup(repo => repo.GetAllProductAsync())
            .ReturnsAsync(mockProducts);

        var accountService = new ProductService(mockRepo.Object);
        
        var result = await accountService.GetAllProductsAsync();
        
        Assert.NotNull(result);
        Assert.Equal(2, mockProducts.Count); 
        Assert.Equal("Apple", mockProducts[0].Name); 
    }
}

   