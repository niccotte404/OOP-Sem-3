using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
public interface IAddressee
{
    public void SendManyMessages(IList<Message> messages);
    public void SendOneMessage(Message message);
    public IEnumerable<string> GetAddresseeId();
}
