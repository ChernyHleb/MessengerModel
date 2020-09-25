using System;

namespace Messenger.Domain.MessageModel
{
    public interface IMessage
    {
        public Guid Id { get; }
        public Guid SenderUserId { get; }
        public object Content { get; set; }
        public DateTime CreationDateTime { get; }
        public DateTime EditDateTime { get; }
    }
}