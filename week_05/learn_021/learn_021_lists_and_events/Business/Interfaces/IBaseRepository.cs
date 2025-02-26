namespace Business.Interfaces;

public interface IBaseRepository<TEntity>
{
    string Serialize(List<TEntity> list);
    List<TEntity>? Deserialize(string json);
    public bool SaveToFile(List<TEntity> list);
    public List<TEntity>? GetFromFile();
}