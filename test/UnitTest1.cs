using Xunit;

namespace test;

public class UnitTest1 : IClassFixture<CustomWebApplicationFactory>
{
    private CustomWebApplicationFactory _factory;
    public UnitTest1(CustomWebApplicationFactory factory)
    {
        _factory = factory;
    }
    
    [Fact]
    public void Test1()
    {
        var client = _factory.CreateClient();
    }
}