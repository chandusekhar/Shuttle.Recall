﻿using System;

namespace Shuttle.Recall.Core
{
    public class EventRead
    {
        public EventRead(Guid id, Event @event, DateTime dateRegistered, long sequenceNumber)
        {
            DateRegistered = dateRegistered;
            Event = @event;
            Id = id;
            SequenceNumber = sequenceNumber;
        }

        public Event Event { get; private set; }
        public Guid Id { get; private set; }
        public long SequenceNumber { get; private set; }
        public DateTime DateRegistered { get; private set; }
    }
}