﻿using System;
using System.Collections.Generic;

namespace Shuttle.Recall
{
    public interface IPrimitiveEventRepository
    {
        void Remove(Guid id);
        IEnumerable<PrimitiveEvent> Get(Guid id);
        IEnumerable<PrimitiveEvent> Get(long fromSequenceNumber, long toSequenceNumber, IEnumerable<Type> eventTypes);
        void Save(PrimitiveEvent primitiveEvent);
    }
}