using System;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.Display;
public sealed record Display : IDisplay
{
    public Display(string id)
    {
        Id = id;
    }

    public string Id { get; init; }
    public Message? Message { get; set; }

    public void ShowMessage()
    {
        if (Message is null) return;

        Console.WriteLine($"Title: {Message.Title}");
        Console.WriteLine($"Message: {Message.Body}");
    }
}
