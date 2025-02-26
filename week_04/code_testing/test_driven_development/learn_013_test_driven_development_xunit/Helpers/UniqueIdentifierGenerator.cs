namespace learn_013_test_driven_development_xunit.Helpers;

// behövs inte instansieras, så kan vara static
public static class UniqueIdentifierGenerator
{
    public static string Generate() => Guid.NewGuid().ToString();
}