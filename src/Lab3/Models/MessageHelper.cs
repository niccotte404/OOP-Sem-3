namespace Itmo.ObjectOrientedProgramming.Lab3.Models;
public sealed record MessageHelper
{
    public MessageHelper(Message message)
    {
        Message = message;
        IsRead = false;
    }

    public Message Message { get; set; }
    public bool IsRead { get; set; }
}
