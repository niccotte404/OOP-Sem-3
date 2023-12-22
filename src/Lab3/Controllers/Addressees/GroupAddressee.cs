using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;
public class GroupAddressee : IAddressee
{
    public GroupAddressee()
    {
        Addressees = new List<IAddressee>();
    }

    public IList<IAddressee> Addressees { get; }

    public IEnumerable<string> GetAddresseeId()
    {
        IEnumerable<string> ids = Addressees.Select(addressee => addressee.GetAddresseeId().First());
        return ids;
    }

    public void SendManyMessages(IList<Message> messages)
    {
        if (messages is null) return;
        Addressees.AsParallel().ForAll(addressee => addressee.SendManyMessages(messages));
    }

    public void SendOneMessage(Message message)
    {
        if (message is null) return;
        Addressees.AsParallel().ForAll(addressee => addressee.SendOneMessage(message));
    }
}
