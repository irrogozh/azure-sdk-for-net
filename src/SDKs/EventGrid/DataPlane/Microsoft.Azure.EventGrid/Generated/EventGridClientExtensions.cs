// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EventGridClient.
    /// </summary>
    public static partial class EventGridClientExtensions
    {
            /// <summary>
            /// Publishes a batch of events to an Azure Event Grid topic.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='topicHostname'>
            /// The host name of the topic, e.g. topic1.westus2-1.eventgrid.azure.net
            /// </param>
            /// <param name='events'>
            /// An array of events to be published to Event Grid.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PublishEventsAsync(this IEventGridClient operations, string topicHostname, IList<EventGridEvent> events, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PublishEventsWithHttpMessagesAsync(topicHostname, events, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
