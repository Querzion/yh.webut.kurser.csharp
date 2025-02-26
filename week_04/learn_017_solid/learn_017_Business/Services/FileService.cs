using System.Diagnostics;
using learn_017_Business.Interfaces;

namespace learn_017_Business.Services;

public abstract class FileService : IFileService
{
    private readonly string _directoryPath;
    private readonly string _filePath;

    public FileService(string directoryPath, string fileName)
    {
        _directoryPath = directoryPath;
        _filePath = Path.Combine(_directoryPath, fileName);
    }

    // Us in case the path needs to be changed, path cannot be readonly.
    // public void Initialize(string directoryPath, string fileName)
    // {
    //     _directoryPath = directoryPath;
    //     _filePath = Path.Combine(_directoryPath, fileName);
    // }
    
    public virtual string GetContentFromFile()
    {
        if (File.Exists(_filePath))
        {
            return File.ReadAllText(_filePath);
        }

        return null!;
    }

    public virtual bool SaveContentToFile(string content)
    {
        try
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }

            File.WriteAllText(_filePath, content);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }
}