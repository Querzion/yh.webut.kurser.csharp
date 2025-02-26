namespace Business.Interfaces;

public interface IFileService
{
    void SaveToFile(string content);
    string GetContentFromFile();
}