using System.Diagnostics;
using learn_017_Business.Interfaces;
using learn_017_Business.Models;

namespace learn_017_Business.Repositories;

public class ArticleRepository(IProductFileService productFileService) : BaseRepository<ProductEntity>, IArticleRepository
{
    private readonly IProductFileService _productFileService = productFileService;

    public override bool SaveToFile(List<ProductEntity> list)
    {
        try
        {
            var json = Serialize(list);
            _productFileService.SaveContentToFile(json);
            
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }
    }

    public override List<ProductEntity>? GetFromFile()
    {
        var json = _productFileService.GetContentFromFile();
        var list = Deserialize(json);
        return list;
    }
}