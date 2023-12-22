using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Moq;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.MoqTests;
public class Tests
{
    [Fact]
    public void FilterTest()
    {
        string title = "Greeting";
        string body = "Welcome to our company";
        var message = new Message(title, body, 2);

        var mock = new Mock<IAddressee>();
        var proxy = new AddresseeProxy(mock.Object);
        bool messageResult = proxy.GetOneMessage(message).Filter(1).SendOneMessage();
        Assert.False(messageResult);
    }

    [Fact]
    public void LogTest()
    {
        string title = "Greeting";
        string body = "Welcome to our company";
        var message = new Message(title, body, 1);

        var mock = new Mock<IAddressee>();
        var proxy = new AddresseeProxy(mock.Object);
        bool logResult = proxy.GetOneMessage(message).Logging().IsLogging;
        Assert.True(logResult);
    }

    [Fact]
    public void MessengerTest()
    {
        string title = "Greeting";
        string body = "Welcome to our company";
        var message = new Message(title, body, 1);

        var mock = new Mock<IAddressee>();
        var proxy = new AddresseeProxy(mock.Object);
        bool messageResult = proxy.GetOneMessage(message).Logging().SendOneMessage();
        Assert.True(messageResult);
    }
}
