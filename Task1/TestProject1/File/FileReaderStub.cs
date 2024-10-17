namespace TestProject1.File;

public class FileReaderStub:IFileReader
{
    public Task<string> ReadFileAsync(string filePath)
    {
        return Task.FromResult("Hello World!");
    }
}