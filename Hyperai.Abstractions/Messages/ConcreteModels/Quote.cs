﻿using System;

namespace Hyperai.Messages.ConcreteModels
{
    [Serializable]
    public class Quote : MessageComponent
    {
        public long MessageId { get; set; }

        public Quote(long messageId)
        {
            MessageId = messageId;
        }

        public override int GetHashCode()
        {
            return MessageId.GetHashCode();
        }

        public override string ToString()
        {
            return $"<QUOTE {MessageId}>";
        }
    }
}