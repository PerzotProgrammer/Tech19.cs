namespace Dlugomierz.Tests;

using NUnit.Framework;

[TestFixture]
public class AdapterTest
{
    [Test]
    public void GetDebtValue_ShouldBeEqual()
    {
        IAdapter adapter = new DebtDataAdapter(1_000);
        int expected = 1_000_000;
        Assert.That(adapter.GetDebtValue(), Is.EqualTo(expected));
    }

    [Test]
    public void CheckPayment_ShouldBeEqual()
    {
        IAdapter adapter = new DebtDataAdapter(1_000);
        adapter.CheckPayment("1000");
        int expected = 999_000;
        Assert.That(adapter.GetDebtValue(), Is.EqualTo(expected));
    }

    [Test]
    public void CheckPayment_ArgumentOutOfRange_ShouldThrowException()
    {
        IAdapter adapter = new DebtDataAdapter(1_000);
        try
        {
            adapter.CheckPayment("1_000_000");
        }
        catch (ArgumentOutOfRangeException)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }
    
    [Test]
    public void CheckPayment_BadArgument_ShouldThrowException()
    {
        IAdapter adapter = new DebtDataAdapter(1_000);
        try
        {
            adapter.CheckPayment("abcxyz");
        }
        catch (ArgumentException)
        {
            Assert.Pass();
        }

        Assert.Fail();
    }
}