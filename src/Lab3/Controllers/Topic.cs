using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;
public sealed record Topic
{
    public Topic(IList<Message>? messages, Message? message, IAddressee? addressee)
    {
        Messages = messages;
        Message = message;
        Addressee = addressee;
    }

    public IList<Message>? Messages { get; init; }
    public Message? Message { get; init; }
    public IAddressee? Addressee { get; init; }

    public void SendManyMessages()
    {
        if (Addressee is null || Messages is null) return;
        Addressee.SendManyMessages(Messages);
    }

    public void SendOneMessage()
    {
        if (Addressee is null || Message is null) return;
        Addressee.SendOneMessage(Message);
    }
}