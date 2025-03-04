// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The IdpsSignatureResult. </summary>
    public partial class IdpsSignatureResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="IdpsSignatureResult"/>. </summary>
        internal IdpsSignatureResult()
        {
            SourcePorts = new ChangeTrackingList<string>();
            DestinationPorts = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="IdpsSignatureResult"/>. </summary>
        /// <param name="signatureId"> The ID of the signature. </param>
        /// <param name="mode"> The current mode enforced, 0 - Disabled, 1 - Alert, 2 -Deny. </param>
        /// <param name="severity"> Describes the severity of signature: 1 - High, 2 - Medium, 3 - Low. </param>
        /// <param name="direction"> Describes in which direction signature is being enforced: 0 - OutBound, 1 - InBound, 2 - Any, 3 - Internal, 4 - InternalOutbound. </param>
        /// <param name="group"> Describes the groups the signature belongs to. </param>
        /// <param name="description"> Describes what is the signature enforces. </param>
        /// <param name="protocol"> Describes the protocol the signatures is being enforced in. </param>
        /// <param name="sourcePorts"> Describes the list of source ports related to this signature. </param>
        /// <param name="destinationPorts"> Describes the list of destination ports related to this signature. </param>
        /// <param name="lastUpdated"> Describes the last updated time of the signature (provided from 3rd party vendor). </param>
        /// <param name="inheritedFromParentPolicy"> Describes if this override is inherited from base policy or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IdpsSignatureResult(int? signatureId, FirewallPolicyIdpsSignatureMode? mode, FirewallPolicyIdpsSignatureSeverity? severity, FirewallPolicyIdpsSignatureDirection? direction, string group, string description, string protocol, IReadOnlyList<string> sourcePorts, IReadOnlyList<string> destinationPorts, string lastUpdated, bool? inheritedFromParentPolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SignatureId = signatureId;
            Mode = mode;
            Severity = severity;
            Direction = direction;
            Group = group;
            Description = description;
            Protocol = protocol;
            SourcePorts = sourcePorts;
            DestinationPorts = destinationPorts;
            LastUpdated = lastUpdated;
            InheritedFromParentPolicy = inheritedFromParentPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of the signature. </summary>
        public int? SignatureId { get; }
        /// <summary> The current mode enforced, 0 - Disabled, 1 - Alert, 2 -Deny. </summary>
        public FirewallPolicyIdpsSignatureMode? Mode { get; }
        /// <summary> Describes the severity of signature: 1 - High, 2 - Medium, 3 - Low. </summary>
        public FirewallPolicyIdpsSignatureSeverity? Severity { get; }
        /// <summary> Describes in which direction signature is being enforced: 0 - OutBound, 1 - InBound, 2 - Any, 3 - Internal, 4 - InternalOutbound. </summary>
        public FirewallPolicyIdpsSignatureDirection? Direction { get; }
        /// <summary> Describes the groups the signature belongs to. </summary>
        public string Group { get; }
        /// <summary> Describes what is the signature enforces. </summary>
        public string Description { get; }
        /// <summary> Describes the protocol the signatures is being enforced in. </summary>
        public string Protocol { get; }
        /// <summary> Describes the list of source ports related to this signature. </summary>
        public IReadOnlyList<string> SourcePorts { get; }
        /// <summary> Describes the list of destination ports related to this signature. </summary>
        public IReadOnlyList<string> DestinationPorts { get; }
        /// <summary> Describes the last updated time of the signature (provided from 3rd party vendor). </summary>
        public string LastUpdated { get; }
        /// <summary> Describes if this override is inherited from base policy or not. </summary>
        public bool? InheritedFromParentPolicy { get; }
    }
}
