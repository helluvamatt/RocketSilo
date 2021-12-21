using NUnit.Framework;

namespace RocketSilo.Api.Tests;

public class AlwaysPass
{
    [Test]
    public void Test_AlwaysPass()
    {
        Assert.Pass();
    }
}