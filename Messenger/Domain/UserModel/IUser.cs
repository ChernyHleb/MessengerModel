﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Messenger.Domain.UserModel
{
    public interface IUser
    {
        public Guid Id { get; }
        public string Login { get; }
        public string TelephoneNumber { get; }
        public IEnumerable<Guid> ChatIdCollection { get; }
    }
}