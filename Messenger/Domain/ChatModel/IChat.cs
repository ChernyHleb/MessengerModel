﻿using System;
using System.Collections.Generic;
using Messenger.Domain.MessageModel;

namespace Messenger.Domain.ChatModel
{
    public interface IChat
    {
        public string Name { get; }
        public Guid Id { get; }
        public IEnumerable<Guid> MemberIdCollection { get; }

        public IEnumerable<IMessage> MessageCollection { get; }
        public void SendMessage(IMessage message);
        public void EditMessage(Guid oldmessageId, object content);
        public void DeleteMessage(Guid messageId);
    }
}