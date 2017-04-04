// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using System.Linq;

    /// <summary>
    /// A rule metric data source. The discriminator value is always
    /// RuleMetricDataSource in this case.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Azure.Management.Insights.Models.RuleMetricDataSource")]
    public partial class RuleMetricDataSource : RuleDataSource
    {
        /// <summary>
        /// Initializes a new instance of the RuleMetricDataSource class.
        /// </summary>
        public RuleMetricDataSource() { }

        /// <summary>
        /// Initializes a new instance of the RuleMetricDataSource class.
        /// </summary>
        /// <param name="resourceUri">the resource identifier of the resource
        /// the rule monitors.</param>
        /// <param name="metricName">the name of the metric that defines what
        /// the rule monitors.</param>
        public RuleMetricDataSource(string resourceUri = default(string), string metricName = default(string))
        {
            ResourceUri = resourceUri;
            MetricName = metricName;
        }

        /// <summary>
        /// Gets or sets the resource identifier of the resource the rule
        /// monitors.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceUri")]
        public string ResourceUri { get; set; }

        /// <summary>
        /// Gets or sets the name of the metric that defines what the rule
        /// monitors.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }

    }
}