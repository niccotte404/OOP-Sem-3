using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Builders;
public class MessageBuilder
{
    private string? _title;
    private string? _body;
    private int _importanceLevel;

    public MessageBuilder(Message message)
    {
        InitParams(message);
    }

    public Message Build()
    {
        var message = new Message(_title, _body, _importanceLevel);
        return message;
    }

    public MessageBuilder SetTitle(string title)
    {
        _title = title;
        return this;
    }

    public MessageBuilder SetBody(string body)
    {
        _body = body;
        return this;
    }

    public MessageBuilder SetImportanceLevel(int importanceLevel)
    {
        _importanceLevel = importanceLevel;
        return this;
    }

    private void InitParams(Message message)
    {
        if (message is null) return;
        _title = message.Title;
        _body = message.Body;
        _importanceLevel = message.ImportanceLevel;
    }
}
