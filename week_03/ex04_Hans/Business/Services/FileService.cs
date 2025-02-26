using Business.Interfaces;

namespace Business.Services;

public class FileService : IFileService
{
    private readonly string _directoryPath;
    private readonly string _filePath;

    public FileService(string directoryPath, string fileName)
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName);
    }

    public void SaveContentToFile(string content)
    {
        if (!Directory.Exists(_directoryPath))
            Directory.CreateDirectory(_directoryPath);
        
        File.WriteAllText(_filePath, content);
    }

    public string ReadContentFromFile()
    {
        if (File.Exists(_filePath))
           return File.ReadAllText(_filePath);
            
        return null!;
    }
}