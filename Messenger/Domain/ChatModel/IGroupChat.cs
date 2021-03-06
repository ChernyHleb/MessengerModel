﻿using System;
using System.Collections.Generic;

namespace Messenger.Domain.ChatModel
{
    public interface IGroupChat : IChat
    {
        // Owner and Admin are IUser entities
        public Guid OwnerId { get; }
        public IEnumerable<Guid> AdminIdCollection { get; }

        bool CheckIfUserCanEditMemberIdCollection(Guid userId);
        public void AddUser(Guid userId);
        public void RemoveUser(Guid userId);
        
        bool CheckIfUserCanSendMessage(Guid user);
        bool CheckIfUserCanEditMessage(Guid user, Guid messageId);
        bool CheckIfUserCanDeleteMessage(Guid user, Guid messageId);
    }
}