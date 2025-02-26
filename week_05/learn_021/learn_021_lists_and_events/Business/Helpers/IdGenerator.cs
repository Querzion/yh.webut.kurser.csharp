namespace Business.Helpers;

public static class IdGenerator
{
    public static string GenerateUniqueId()
    {
        return Guid.NewGuid().ToString();
    }
    
    public static int AutoIncrementId(int lastId)
    {
        return lastId != 0 ? lastId + 1 : 1;
    }
}