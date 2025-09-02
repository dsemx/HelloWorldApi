using Xunit;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void HelloWorld_Test()
    {
        var message = "Hello, World!";
        Assert.Equal("Hello, World!", message);
    }
}
