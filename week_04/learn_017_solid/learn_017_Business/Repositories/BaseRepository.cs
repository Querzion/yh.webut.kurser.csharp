using System.Text.Json;
using learn_017_Business.Interfaces;

namespace learn_017_Business.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
{
    public virtual string Serialize(List<TEntity> list)
    {
        var json = JsonSerializer.Serialize(list);
        return json;
    }
    
    public virtual List<TEntity>? Deserialize(string json)
    {
        var data = JsonSerializer.Deserialize<List<TEntity>>(json);
        return data;
    }
    
    public abstract bool SaveToFile(List<TEntity> list);
    public abstract List<TEntity>? GetFromFile();
}