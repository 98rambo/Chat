using Chat.Data.Interfaces;
using Chat.Data.Models;
using System.Collections.Generic;

namespace Chat.Data.Repository
{
    public class MsgRepository : IMessage
    {
        private readonly MsgDBContext MsgDBContext;

        public MsgRepository(MsgDBContext MsgDBContext)
        {
            this.MsgDBContext = MsgDBContext;
        }

        public IEnumerable<Message> AllMessages => MsgDBContext.Messages;

        public void AddMessage(Message Msg)
        {
            MsgDBContext.Messages.Add(Msg);
            MsgDBContext.SaveChanges();
        }
    }
}
