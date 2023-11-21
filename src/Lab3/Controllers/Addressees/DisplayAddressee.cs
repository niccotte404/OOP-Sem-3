using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Display;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;
public class DisplayAddressee : IAddressee
{
    public DisplayAddressee(Display addressee)
    {
        Addressee = addressee;
    }

    public Display Addressee { get; set; }

    public IEnumerable<string> GetAddresseeId()
    {
        var ids = new List<string>() { Addressee.Id };
        return ids;
    }

    public void SendManyMessages(IList<Message> messages)
    {
        if (messages is null) return;
        Addressee.Message = messages.First();
        messages.Remove(messages.First());
    }

    public void SendOneMessage(Message message)
    {
        if (message is null) return;
        Addressee.Message = message;
    }
}
