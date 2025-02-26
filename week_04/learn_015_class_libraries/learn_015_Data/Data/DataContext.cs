namespace learn_015_Data.Data;

public class DataContext<T> where T : class
{
    private readonly List<T> _data = [];
    
    public IEnumerable<T> Items() => _data;

    public bool Save(T item)
    {
        _data.Add(item);
        return true;
    }
}