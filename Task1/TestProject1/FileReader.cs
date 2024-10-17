namespace TestProject1;

public class FileReader
{
    public async Task<string> ReadFileAsync(string filePath)
    {
        if (!System.IO.File.Exists(filePath))
        {
            throw new FileNotFoundException("Файл не знайдено");
        }

        return await System.IO.File.ReadAllTextAsync(filePath);
    }
}