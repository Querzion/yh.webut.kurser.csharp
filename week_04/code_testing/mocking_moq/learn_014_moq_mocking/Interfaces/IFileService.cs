namespace learn_014_moq_mocking.Interfaces;

public interface IFileService
{
    string GetContentFromFile();
    bool SaveContentToFile(string content);
}