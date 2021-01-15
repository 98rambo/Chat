using Chat.Data.Models;
using System.Collections.Generic;

namespace Chat.Data.Interfaces
{
    public interface IMessage
    {
        IEnumerable<Message> AllMessages { get; }

        void AddMessage(Message Msg);
    }
}
