﻿using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }

        public Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
