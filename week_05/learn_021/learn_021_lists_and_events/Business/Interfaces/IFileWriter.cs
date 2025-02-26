namespace Business.Interfaces;

public interface IFileWriter
{
    bool SaveContentToFile(string content);
}