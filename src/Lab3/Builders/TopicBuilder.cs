using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Builders;
public class TopicBuilder : ITopicBuilder
{
    private IList<Message>? _messages;
    private Message? _message;
    private IAddressee? _addressee;

    public Topic Build()
    {
        var topic = new Topic(_messages, _message, _addressee);
        return topic;
    }

    public ITopicBuilder GetAddressee(IAddressee addressee)
    {
        _addressee = addressee;
        return this;
    }

    public ITopicBuilder GetManyMessages(IList<Message> messages)
    {
        _messages = messages;
        return this;
    }

    public ITopicBuilder GetOneMessage(Message message)
    {
        _message = message;
        return this;
    }
}
