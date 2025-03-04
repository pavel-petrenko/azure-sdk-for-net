// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The ExtendedThroughputSettingsResourceInfo. </summary>
    public partial class ExtendedThroughputSettingsResourceInfo : ThroughputSettingsResourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="ExtendedThroughputSettingsResourceInfo"/>. </summary>
        public ExtendedThroughputSettingsResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedThroughputSettingsResourceInfo"/>. </summary>
        /// <param name="throughput"> Value of the Cosmos DB resource throughput. Either throughput is required or autoscaleSettings is required, but not both. </param>
        /// <param name="autoscaleSettings"> Cosmos DB resource for autoscale settings. Either throughput is required or autoscaleSettings is required, but not both. </param>
        /// <param name="minimumThroughput"> The minimum throughput of the resource. </param>
        /// <param name="offerReplacePending"> The throughput replace is pending. </param>
        /// <param name="instantMaximumThroughput"> The offer throughput value to instantly scale up without triggering splits. </param>
        /// <param name="softAllowedMaximumThroughput"> The maximum throughput value or the maximum maxThroughput value (for autoscale) that can be specified. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="timestamp"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        internal ExtendedThroughputSettingsResourceInfo(int? throughput, AutoscaleSettingsResourceInfo autoscaleSettings, string minimumThroughput, string offerReplacePending, string instantMaximumThroughput, string softAllowedMaximumThroughput, IDictionary<string, BinaryData> serializedAdditionalRawData, string rid, float? timestamp, ETag? etag) : base(throughput, autoscaleSettings, minimumThroughput, offerReplacePending, instantMaximumThroughput, softAllowedMaximumThroughput, serializedAdditionalRawData)
        {
            Rid = rid;
            Timestamp = timestamp;
            ETag = etag;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Timestamp { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public ETag? ETag { get; }
    }
}
