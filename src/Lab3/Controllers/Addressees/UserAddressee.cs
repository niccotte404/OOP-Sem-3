using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;
public class UserAddressee : IAddressee
{
    public UserAddressee(User addressee)
    {
        Addressee = addressee;
    }

    public User Addressee { get; set; }

    public IEnumerable<string> GetAddresseeId()
    {
        var ids = new List<string>() { Addressee.Id };
        return ids;
    }

    public void SendManyMessages(IList<Message> messages)
    {
        if (messages is null) return;
        messages.AsParallel().ForAll(message => Addressee.Messages.Add(new MessageHelper(message)));
    }

    public void SendOneMessage(Message message)
    {
        if (message is null) return;
        var messageHelper = new MessageHelper(message);
        Addressee.Messages.Add(messageHelper);
    }
}
