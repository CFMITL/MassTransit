﻿// Copyright 2007-2015 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.AzureServiceBusTransport
{
    using System;


    public interface IQueueConfigurator
    {
        /// <summary>
        /// True if the queue should be deleted if idle
        /// </summary>
        TimeSpan AutoDeleteOnIdle { set; }

        /// <summary>
        /// Set the default message time to live in the queue
        /// </summary>
        TimeSpan DefaultMessageTimeToLive { set; }

        /// <summary>
        /// Sets the TimeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes
        /// </summary>
        TimeSpan DuplicateDetectionHistoryTimeWindow { set; }

        /// <summary>
        /// Sets a value that indicates whether server-side batched operations are enabled
        /// </summary>
        bool EnableBatchedOperations { set; }

        /// <summary>
        /// Move messages to the dead letter queue on expiration (time to live exceeded)
        /// </summary>
        bool EnableDeadLetteringOnMessageExpiration { set; }

        /// <summary>
        /// If express is enabled, messages are not persisted to durable storage
        /// </summary>
        /// <value>True for a durable queue, False for an in-memory queue</value>
        bool EnableExpress { set; }

        /// <summary>
        /// Sets a value that indicates whether the queue to be partitioned across multiple message brokers is enabled
        /// </summary>
        bool EnablePartitioning { set; }

        /// <summary>
        /// Sets the path to the recipient to which the dead lettered message is forwarded.
        /// </summary>
        string ForwardDeadLetteredMessagesTo { set; }

        /// <summary>
        /// Sets a value that indicates whether the message is anonymous accessible.
        /// </summary>
        bool IsAnonymousAccessible { set; }

        /// <summary>
        /// Specify the lock duration for messages read from the queue
        /// </summary>
        /// <value></value>
        TimeSpan LockDuration { set; }

        /// <summary>
        /// Sets the maximum delivery count. A message is automatically deadlettered after this number of deliveries.
        /// </summary>
        int MaxDeliveryCount { set; }

        /// <summary>
        /// Sets the maximum size of the queue in megabytes, which is the size of memory allocated for the queue
        /// </summary>
        int MaxSizeInMegabytes { set; }

        /// <summary>
        /// Sets the value indicating if this queue requires duplicate detection.
        /// </summary>
        bool RequiresDuplicateDetection { set; }

        /// <summary>
        /// Sets the queue in session mode, requiring a session for inbound messages
        /// </summary>
        bool RequiresSession { set; }

        /// <summary>
        /// Sets a value that indicates whether the queue supports ordering.
        /// </summary>
        bool SupportOrdering { set; }

        /// <summary>
        /// Sets the user metadata.
        /// </summary>
        string UserMetadata { set; }

        /// <summary>
        /// Enable duplicate detection on the queue, specifying the time window
        /// </summary>
        /// <param name="historyTimeWindow">The time window for duplicate history</param>
        void EnableDuplicateDetection(TimeSpan historyTimeWindow);
    }
}