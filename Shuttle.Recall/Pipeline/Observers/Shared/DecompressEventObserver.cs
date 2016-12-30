﻿using System;
using Shuttle.Core.Infrastructure;

namespace Shuttle.Recall
{
	public class DecompressEventObserver : IPipelineObserver<OnDecompressEvent>
	{
        private readonly IEventStoreConfiguration _configuration;

        public DecompressEventObserver(IEventStoreConfiguration configuration)
        {
            Guard.AgainstNull(configuration, "configuration");

            _configuration = configuration;
        }

        public void Execute(OnDecompressEvent pipelineEvent)
		{
			var state = pipelineEvent.Pipeline.State;
			var eventEnvelope = state.GetEventEnvelope();

			if (!eventEnvelope.CompressionEnabled())
			{
				return;
			}

			var algorithm = _configuration.FindCompressionAlgorithm(eventEnvelope.CompressionAlgorithm);

            if (algorithm == null)
            {
                throw new InvalidOperationException(string.Format(InfrastructureResources.MissingCompressionAlgorithmException, eventEnvelope.CompressionAlgorithm));
            }

			eventEnvelope.Event = algorithm.Decompress(eventEnvelope.Event);
		}
	}
}