namespace Business2.Helpers;

public static class UniqueIdentifierGenerator
{
    public static string Generate()
    {
        return Guid.NewGuid().ToString().Split('-')[0];
    }
}
