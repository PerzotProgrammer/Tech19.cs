namespace Dlugomierz.Tests;

using NUnit.Framework;

[TestFixture]
public class DaoTest
{
    [Test]
    public void CalculateNewDebtValue_ShouldBeEqual()
    {
        IDao dao = new DebtData(1_000);
        dao.CalculateNewDebtValue(100);
        int expected = 900;
        Assert.That(expected, Is.EqualTo(dao.DebtValue));
    }

    [Test]
    public void CalculateNewDebtValue_ShouldBeEqualZero()
    {
        IDao dao = new DebtData(1_000);
        dao.CalculateNewDebtValue(1_001);
        int expected = 0;
        Assert.That(expected, Is.EqualTo(dao.DebtValue));
    }

    [Test]
    public void CalculateNewDebtValue_ShouldBeNotEqual()
    {
        IDao dao = new DebtData(1_000);
        dao.CalculateNewDebtValue(1_000_000);
        int expected = -999_000;
        Assert.That(expected, Is.Not.EqualTo(dao.DebtValue));
    }
}