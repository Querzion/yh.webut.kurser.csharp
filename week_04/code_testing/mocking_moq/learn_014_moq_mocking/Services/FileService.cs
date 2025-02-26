using learn_014_moq_mocking.Interfaces;

namespace learn_014_moq_mocking.Services;

public class FileService : IFileService
{
    private readonly string _directoryPath;
    private readonly string _filePath;

    public FileService(string directoryPath = "Data", String fileName = "Content.json")
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName);
    }
    
    public bool SaveContentToFile(string content)
    {
        try
        {
            if (!Directory.Exists(_directoryPath))
                Directory.CreateDirectory(_directoryPath);
            
            File.WriteAllText(content, _filePath);
            return true;
        }
        catch
        {
            return false;
        }
    }
    
    public string GetContentFromFile()
    {
        try
        {
            if (File.Exists(_filePath))
                return File.ReadAllText(_filePath);
        }
        catch
        {
            return null!; 
        }

        return null!;
    }
}