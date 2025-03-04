// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A dictionary of index projection-specific configuration properties. Each name is the name of a specific property. Each value must be of a primitive type. </summary>
    public partial class SearchIndexerIndexProjectionsParameters
    {
        /// <summary> Initializes a new instance of <see cref="SearchIndexerIndexProjectionsParameters"/>. </summary>
        public SearchIndexerIndexProjectionsParameters()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchIndexerIndexProjectionsParameters"/>. </summary>
        /// <param name="projectionMode"> Defines behavior of the index projections in relation to the rest of the indexer. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SearchIndexerIndexProjectionsParameters(IndexProjectionMode? projectionMode, IDictionary<string, object> additionalProperties)
        {
            ProjectionMode = projectionMode;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Defines behavior of the index projections in relation to the rest of the indexer. </summary>
        public IndexProjectionMode? ProjectionMode { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
