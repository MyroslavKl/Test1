using TestProject1.File;

namespace Task1;

using System.Threading.Tasks;
using Xunit;

public class FileReaderTests
{
    [Fact]
    public async Task ReadFileAsync_ReturnsStubData()
    {
        // Arrange
        IFileReader fileReader = new FileReaderStub(); 

        // Act
        var result = await fileReader.ReadFileAsync("stub.txt");

        // Assert
        Assert.Equal("Hello World!", result); 
    }
}