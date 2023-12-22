using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Entities;
public sealed record User
{
    public User(string id, string? name)
    {
        Id = id;
        Name = name;
        Messages = new List<MessageHelper>();
    }

    public string Id { get; init; }
    public string? Name { get; init; }
    public IList<MessageHelper> Messages { get; }

    public void SetMessageAsRead(Message message)
    {
        if (message is null) return;

        MessageHelper? tmpMessage = Messages.FirstOrDefault(elem => elem.Message == message);

        string? param = "Required message not found in user messages";
        if (tmpMessage is null)
            throw new ArgumentNullException(param);

        if (tmpMessage.IsRead == false)
            tmpMessage.IsRead = true;
        else
            throw new ArgumentException("Message is marked as read");
    }
}