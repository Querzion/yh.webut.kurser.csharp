using learn_017_Business.Interfaces;

namespace learn_017_Business.Services;

public class UserFileService : FileService, IUserFileService
{
    public UserFileService(string directoryPath, string fileName) : base(directoryPath, fileName)
    {
        
    }
}