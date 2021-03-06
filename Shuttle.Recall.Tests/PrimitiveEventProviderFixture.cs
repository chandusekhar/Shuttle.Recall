﻿using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Shuttle.Core.Threading;

namespace Shuttle.Recall.Tests
{
    public class TestEvent
    {
    }

    [TestFixture]
    public class PrimitiveEventProviderFixture : IEventHandler<TestEvent>, IThreadState
    {
        [Test]
        public void Should_be_able_to_use_provider()
        {
            var projection = new Projection("projection", 15, Environment.MachineName, AppDomain.CurrentDomain.BaseDirectory);

            projection.AddEventHandler(this);

            var eventProcessor = new Mock<IEventProcessor>();
            var projectionAggregation = new ProjectionAggregation(100);

            projectionAggregation.Add(projection);

            eventProcessor.Setup(m => m.GetProjectionAggregation(It.IsAny<Guid>())).Returns(projectionAggregation);

            var configuration = new Mock<IEventStoreConfiguration>();
            var provider = new ProjectionEventProvider(configuration.Object, eventProcessor.Object, GetRepository());

            ProjectionEvent projectionEvent;

            var eventEnvelope = new EventEnvelope
            {
                AssemblyQualifiedName = typeof(TestEvent).AssemblyQualifiedName
            };

            Assert.That(projectionAggregation.IsEmpty, Is.True);

            for (var i = 0; i < 10; i++)
            {
                projectionEvent = provider.Get(projection);

                Assert.That(projectionEvent, Is.Not.Null);
                Assert.That(projectionAggregation.IsEmpty, Is.False);

                projection.Process(eventEnvelope, new TestEvent(), projectionEvent.PrimitiveEvent, this);

                projectionAggregation.ProcessSequenceNumberTail();
            }

            projectionEvent = provider.Get(projection);

            Assert.That(projectionEvent.HasPrimitiveEvent, Is.False);
            Assert.That(projectionAggregation.IsEmpty, Is.True);
        }

        private IPrimitiveEventRepository GetRepository()
        {
            var repository = new Mock<IPrimitiveEventRepository>();
            var events = new List<PrimitiveEvent>();

            for (int i = 0; i < 10; i++)
            {
                events.Add(new PrimitiveEvent
                {
                    SequenceNumber = i + 16
                });
            }

            repository.SetupSequence(m => m.Get(It.IsAny<long>(), It.IsAny<long>(), It.IsAny<IEnumerable<Type>>()))
                .Returns(events)
                .Returns(new List<PrimitiveEvent>());

            return repository.Object;
        }

        public void ProcessEvent(IEventHandlerContext<TestEvent> context)
        {
        }

        public bool Active => true;
    }
}