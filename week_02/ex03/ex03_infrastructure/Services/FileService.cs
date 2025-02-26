namespace ex03_infrastructure.Services;

public class FileService
{
    private readonly string _directoryPath;
    private readonly string _filePath;

    public FileService(string directoryPath = "Data", string fileName = "users.json")
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName);
    }
    
    #region Methods

    public void SaveUsersToFile(string users)
    {
        if (!string.IsNullOrWhiteSpace(users))
        {
            if (!Directory.Exists(_directoryPath))
                Directory.CreateDirectory(_directoryPath);
            
            File.WriteAllText(_filePath, users);
        }
    }

    public string? GetUsersFromFile()
    {
        if (File.Exists(_filePath))
            return File.ReadAllText(_filePath);
        
        return null;
    }
    
    #endregion
}