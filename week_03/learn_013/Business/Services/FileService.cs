using Business.Interfaces;

namespace Business.Services;

public class FileService : IFileService
{
    private string _directoryPath;
    private string _filePath;

    public FileService(string directoryPath = "Data", string fileName = "content.json")
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName);
    } 
    
    
    #region Methods

    public void SaveToFile(string content)
    {
        if (!Directory.Exists(_directoryPath))
            Directory.CreateDirectory(_directoryPath);
        
        using var sw = new StreamWriter(_filePath);
        sw.WriteLine(content);
    }

    public string GetContentFromFile()
    {
        if (File.Exists(_filePath))
        {
            using var sr = new StreamReader(_filePath);
            string content = sr.ReadToEnd();
            return content;
        }

        return null!;
    }
    

    #endregion
}