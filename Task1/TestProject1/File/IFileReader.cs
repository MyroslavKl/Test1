namespace TestProject1.File;

public interface IFileReader
{
    Task<string> ReadFileAsync(string filePath);
}