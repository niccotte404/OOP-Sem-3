using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Messenger;
public sealed record Messenger
{
    public Messenger(string token)
    {
        Token = token;
        Messages = new List<Message>();
    }

    public string Token { get; init; }
    public IList<Message> Messages { get; }
}