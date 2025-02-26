using learn_013_test_driven_development_xunit.Helpers;

namespace learn_013_test_driven_development_xunit_tests.Helpers;

public class UniqueIdentifierGeneratorTests
{
    [Fact]
    public void Generate_ShouldReturnStringOfTypeGuid()
    {
        // Act
        string id = UniqueIdentifierGenerator.Generate();
        
        // Assert
        Assert.False(string.IsNullOrEmpty(id));
        // _ = Discard, vi vill bara ha ett true eller false värde.
        Assert.True(Guid.TryParse(id, out _));
    }
}