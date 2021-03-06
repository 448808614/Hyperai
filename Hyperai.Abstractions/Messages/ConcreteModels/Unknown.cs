﻿namespace Hyperai.Messages.ConcreteModels
{
    public class Unknown : MessageComponent
    {
        public string Data { get; set; }

        public Unknown(string data)
        {
            Data = data;
        }

        public override int GetHashCode()
        {
            return Data.GetHashCode();
        }
    }
}