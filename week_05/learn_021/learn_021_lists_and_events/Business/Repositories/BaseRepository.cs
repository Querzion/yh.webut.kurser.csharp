using System.Text.Json;
using Business.Interfaces;

namespace Business.Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
{
    public virtual string Serialize(List<TEntity> list)
    {
        var json = JsonSerializer.Serialize(list);
        return json;
    }

    public virtual List<TEntity>? Deserialize(string json)
    {
        var jsonObject = JsonSerializer.Deserialize<List<TEntity>>(json);
        return jsonObject ?? new List<TEntity>();
    }

    public abstract bool SaveToFile(List<TEntity> list);
    public abstract List<TEntity>? GetFromFile();
}