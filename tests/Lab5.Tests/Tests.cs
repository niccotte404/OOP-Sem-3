using Moq;
using Ports.Ports;
using Xunit;
using AppContext = Application.AppContext;

namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class Tests
{
    [Fact]
    public void DecreaseBalanceTest()
    {
        int currBalance = 0;
        int decreaseBalance = 10;
        string userId = "1";
        var mock = new Mock<IUserDbRepository>();
        mock.Object.SetBalance(userId, currBalance - decreaseBalance);
        Assert.Equal(0, AppContext.Balance);
    }

    [Fact]
    public void DecreaseBalanceTestSecond()
    {
        int currBalance = 10;
        int decreaseBalance = 10;
        string userId = "1";
        var mock = new Mock<IUserDbRepository>();
        mock.Object.SetBalance(userId, currBalance - decreaseBalance);
        Assert.Equal(0, AppContext.Balance);
    }

    [Fact]
    public void IncreaseBalanceTestSecond()
    {
        int currBalance = -10;
        int decreaseBalance = 10;
        string userId = "1";
        var mock = new Mock<IUserDbRepository>();
        mock.Object.SetBalance(userId, currBalance + decreaseBalance);
        Assert.Equal(0, AppContext.Balance);
    }
}