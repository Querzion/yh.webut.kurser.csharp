namespace Business.Interfaces;

public interface IFileService
{
    void SaveContentToFile(string content);
    string ReadContentFromFile();
}