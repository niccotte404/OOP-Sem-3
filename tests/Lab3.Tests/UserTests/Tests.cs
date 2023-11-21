using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Builders;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab3.Tests.UserTests;

public class Tests
{
    [Fact]
    public void UnreadMessage()
    {
        string title = "Greeting";
        string body = "Welcome to our company";
        var message = new Message(title, body, 1);
        var topicBuilder = new TopicBuilder();
        var user = new User("A1", "Alex");
        IAddressee addressee = new UserAddressee(user);
        Topic topic = topicBuilder.GetOneMessage(message).GetAddressee(addressee).Build();
        topic.SendOneMessage();

        MessageHelper userMessage = user.Messages.First();
        Assert.False(userMessage.IsRead);
    }

    [Fact]
    public void SetReadMessage()
    {
        string title = "Greeting";
        string body = "Welcome to our company";
        var message = new Message(title, body, 1);
        var topicBuilder = new TopicBuilder();
        var user = new User("A1", "Alex");
        IAddressee addressee = new UserAddressee(user);
        Topic topic = topicBuilder.GetOneMessage(message).GetAddressee(addressee).Build();
        topic.SendOneMessage();

        user.SetMessageAsRead(message);
        MessageHelper userMessage = user.Messages.First();
        Assert.True(userMessage.IsRead);
    }

    [Fact]
    public void SetReadMessageAsUnread()
    {
        string title = "Greeting";
        string body = "Welcome to our company";
        var message = new Message(title, body, 1);
        var topicBuilder = new TopicBuilder();
        var user = new User("A1", "Alex");
        IAddressee addressee = new UserAddressee(user);
        Topic topic = topicBuilder.GetOneMessage(message).GetAddressee(addressee).Build();
        topic.SendOneMessage();

        user.SetMessageAsRead(message);
        try
        {
            user.SetMessageAsRead(message);
        }
        catch (ArgumentException ex)
        {
            Assert.Equal("Message is marked as read", ex.Message);
        }
    }
}