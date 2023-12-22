using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;
public class AddresseeProxy : IAddressee
{
    private readonly IAddressee _addressee;
    private IList<Message>? _messages;
    private Message? _message;

    public AddresseeProxy(IAddressee addressee)
    {
        _addressee = addressee;
        _message = null;
        _messages = null;
        IsLogging = false;
    }

    public bool IsLogging { get; private set; }

    public IEnumerable<string> GetAddresseeId()
    {
        return _addressee.GetAddresseeId();
    }

    public void SendManyMessages(IList<Message> messages)
    {
        if (messages is null) return;
        _addressee.SendManyMessages(messages);
    }

    public void SendOneMessage(Message message)
    {
        if (message is null) return;
        _addressee.SendOneMessage(message);
    }

    public bool SendManyMessages()
    {
        if (_messages is null) return false;
        _addressee.SendManyMessages(_messages);

        return true;
    }

    public bool SendOneMessage()
    {
        if (_message is null) return false;
        _addressee.SendOneMessage(_message);
        return true;
    }

    public AddresseeProxy GetManyMessages(IList<Message> messages)
    {
        _messages = messages;
        return this;
    }

    public AddresseeProxy GetOneMessage(Message message)
    {
        _message = message;
        return this;
    }

    public AddresseeProxy Filter(int addresseeImportanceLevel)
    {
        if (_messages is not null)
            _messages = _messages.Where(msg => msg.ImportanceLevel > addresseeImportanceLevel).ToList();
        else if (_message is not null && _message.ImportanceLevel > addresseeImportanceLevel)
            _message = null;

        return this;
    }

    public AddresseeProxy Logging()
    {
        string? title = null;
        string? directory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
        StreamWriter fileStream = File.AppendText(directory + "\\log.txt");
        if (_message is not null && _message.Title is not null)
            title = _message.Title;
        using (fileStream)
        {
            try
            {
                foreach (string id in GetAddresseeId())
                {
                    string time = DateTime.Now.ToString("H:mm:ss MM.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    var sb = new StringBuilder();
                    string message = sb.Append(time).Append(id).Append(title).ToString();
                    fileStream.WriteLine(message);
                }
            }
            catch (NullReferenceException)
            {
                string time = DateTime.Now.ToString("H:mm:ss MM.yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                string message = time + "\n" + $"ID: null ('cause of mock)\n" + title + "\n\n";
                fileStream.WriteLine(message);
            }
        }

        IsLogging = true;
        return this;
    }
}