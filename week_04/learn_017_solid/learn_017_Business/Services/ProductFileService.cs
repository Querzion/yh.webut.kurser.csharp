using learn_017_Business.Interfaces;

namespace learn_017_Business.Services;

public class ProductFileService : FileService, IProductFileService
{
    public ProductFileService(string directoryPath, string fileName) : base(directoryPath, fileName)
    {
        
    }
}