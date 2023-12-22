using System;
using System.IO;
using Crayon;
using Itmo.ObjectOrientedProgramming.Lab3.Builders;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Display;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;
public class DisplayDriver : IDisplay
{
    private MessageBuilder? _messageBuilder;
    private Display _addressee;
    public DisplayDriver(Display addressee)
    {
        _addressee = addressee;
        InitMessageBuilder();
    }

    public static void ClearOutput() => Console.Clear();

    public void SetColor(IOutput color)
    {
        if (color is null || _addressee.Message is null || _addressee.Message.Title is null ||
            _addressee.Message.Body is null || _messageBuilder is null)
            return;

        Message msg = _messageBuilder.SetTitle(color.Text(_addressee.Message.Title))
            .SetBody(color.Text(_addressee.Message.Body))
            .SetImportanceLevel(_addressee.Message.ImportanceLevel)
            .Build();
        _addressee.Message = msg;
    }

    public void WriteMessage()
    {
        string message = string.Empty;
        if (_addressee.Message is not null)
            message = "\n" + _addressee.Message.Title + "\n" + _addressee.Message.Body + "\n\n";
        string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        var fileStream = new StreamWriter(Path.Combine(directory, "DisplayOutput.txt"));
        using (fileStream)
        {
            if (string.IsNullOrEmpty(message) == false)
                fileStream.WriteLine(message);
        }

        fileStream.Close();
    }

    public void ShowMessage()
    {
        _addressee.ShowMessage();
    }

    private void InitMessageBuilder()
    {
        if (_addressee.Message is not null)
            _messageBuilder = new MessageBuilder(_addressee.Message);
    }
}
