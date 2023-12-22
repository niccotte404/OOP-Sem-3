using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Models.Messenger;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;
public class MessengerAddressee : IAddressee
{
    public MessengerAddressee(Messenger addressee)
    {
        Addressee = addressee;
    }

    public Messenger Addressee { get; set; }

    public IEnumerable<string> GetAddresseeId()
    {
        var ids = new List<string>() { Addressee.Token };
        return ids;
    }

    public void SendManyMessages(IList<Message> messages)
    {
        if (messages is null) return;
        messages.AsParallel().ForAll(message => Addressee.Messages.Add(message));
    }

    public void SendOneMessage(Message message)
    {
        if (message is null) return;
        Addressee.Messages.Add(message);
    }
}
