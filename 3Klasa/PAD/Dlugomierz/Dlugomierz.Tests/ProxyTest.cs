namespace Dlugomierz.Tests;

using NUnit.Framework;

[TestFixture]
public class ProxyTest
{
    
    [Test]
    public void CalculateNewDebtValue_ShouldBeNotEqual()
    {
        Proxy proxy = new Proxy();
        proxy.TryCalculate("1_000_000");
        int expected = 1_000_000;
        Assert.That(expected, Is.Not.EqualTo(proxy.GetDebtValue()));
    }
    
    [Test]
    public void CalculateNewDebtValue_ShouldBeEqual()
    {
        Proxy proxy = new Proxy();
        proxy.TryCalculate("1000");
        int expected = 999_000;
        Assert.That(expected, Is.EqualTo(proxy.GetDebtValue()));
    }
    
    [Test]
    public void ReturnValue_ShouldBeEqual()
    {
        Proxy proxy = new Proxy();
        string output = proxy.TryCalculate("1001");
        string expected = "Zapłacono: 1001 zł";
        Assert.That(expected, Is.EqualTo(output));
    }
    
    [Test]
    public void ReturnValue_ShouldBeEqualZero()
    {
        Proxy proxy = new Proxy();
        proxy.TryCalculate("1_000_000");
        string output = proxy.TryCalculate("1_000_000");
        string expected = "Dług spłacony";
        Assert.That(expected, Is.EqualTo(output));
    }
}