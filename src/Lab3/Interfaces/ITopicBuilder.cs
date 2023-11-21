using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Interfaces;
public interface ITopicBuilder
{
    public ITopicBuilder GetOneMessage(Message message);
    public ITopicBuilder GetManyMessages(IList<Message> messages);
    public ITopicBuilder GetAddressee(IAddressee addressee);
    public Topic Build();
}
