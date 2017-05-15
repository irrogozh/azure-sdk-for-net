// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Azure;
    using Management;
    using Network;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Usage strings container.
    /// </summary>
    public partial class VirtualNetworkUsageName
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkUsageName class.
        /// </summary>
        public VirtualNetworkUsageName() { }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkUsageName class.
        /// </summary>
        /// <param name="localizedValue">Localized subnet size and usage
        /// string.</param>
        /// <param name="value">Subnet size and usage string.</param>
        public VirtualNetworkUsageName(string localizedValue = default(string), string value = default(string))
        {
            LocalizedValue = localizedValue;
            Value = value;
        }

        /// <summary>
        /// Gets localized subnet size and usage string.
        /// </summary>
        [JsonProperty(PropertyName = "localizedValue")]
        public string LocalizedValue { get; protected set; }

        /// <summary>
        /// Gets subnet size and usage string.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; protected set; }

    }
}

