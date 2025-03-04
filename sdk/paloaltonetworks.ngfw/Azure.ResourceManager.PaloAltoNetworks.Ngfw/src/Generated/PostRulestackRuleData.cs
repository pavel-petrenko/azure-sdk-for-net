// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    /// <summary>
    /// A class representing the PostRulestackRule data model.
    /// PostRulestack rule list
    /// </summary>
    public partial class PostRulestackRuleData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="PostRulestackRuleData"/>. </summary>
        /// <param name="ruleName"> rule name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public PostRulestackRuleData(string ruleName)
        {
            Argument.AssertNotNull(ruleName, nameof(ruleName));

            RuleName = ruleName;
            Applications = new ChangeTrackingList<string>();
            ProtocolPortList = new ChangeTrackingList<string>();
            Tags = new ChangeTrackingList<RulestackTagInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="PostRulestackRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> etag info. </param>
        /// <param name="ruleName"> rule name. </param>
        /// <param name="priority"></param>
        /// <param name="description"> rule description. </param>
        /// <param name="ruleState"> state of this rule. </param>
        /// <param name="source"> source address. </param>
        /// <param name="negateSource"> cidr should not be 'any'. </param>
        /// <param name="destination"> destination address. </param>
        /// <param name="negateDestination"> cidr should not be 'any'. </param>
        /// <param name="applications"> array of rule applications. </param>
        /// <param name="category"> rule category. </param>
        /// <param name="protocol"> any, application-default, TCP:number, UDP:number. </param>
        /// <param name="protocolPortList"> prot port list. </param>
        /// <param name="inboundInspectionCertificate"> inbound Inspection Certificate. </param>
        /// <param name="auditComment"> rule comment. </param>
        /// <param name="actionType"> rule action. </param>
        /// <param name="enableLogging"> enable or disable logging. </param>
        /// <param name="decryptionRuleType"> enable or disable decryption. </param>
        /// <param name="tags"> tag for rule. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PostRulestackRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, string ruleName, int? priority, string description, RulestackStateType? ruleState, SourceAddressInfo source, FirewallBooleanType? negateSource, DestinationAddressInfo destination, FirewallBooleanType? negateDestination, IList<string> applications, EdlMatchCategory category, string protocol, IList<string> protocolPortList, string inboundInspectionCertificate, string auditComment, RulestackActionType? actionType, RulestackStateType? enableLogging, DecryptionRuleType? decryptionRuleType, IList<RulestackTagInfo> tags, FirewallProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            RuleName = ruleName;
            Priority = priority;
            Description = description;
            RuleState = ruleState;
            Source = source;
            NegateSource = negateSource;
            Destination = destination;
            NegateDestination = negateDestination;
            Applications = applications;
            Category = category;
            Protocol = protocol;
            ProtocolPortList = protocolPortList;
            InboundInspectionCertificate = inboundInspectionCertificate;
            AuditComment = auditComment;
            ActionType = actionType;
            EnableLogging = enableLogging;
            DecryptionRuleType = decryptionRuleType;
            Tags = tags;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PostRulestackRuleData"/> for deserialization. </summary>
        internal PostRulestackRuleData()
        {
        }

        /// <summary> etag info. </summary>
        public ETag? ETag { get; set; }
        /// <summary> rule name. </summary>
        public string RuleName { get; set; }
        /// <summary> Gets the priority. </summary>
        public int? Priority { get; }
        /// <summary> rule description. </summary>
        public string Description { get; set; }
        /// <summary> state of this rule. </summary>
        public RulestackStateType? RuleState { get; set; }
        /// <summary> source address. </summary>
        public SourceAddressInfo Source { get; set; }
        /// <summary> cidr should not be 'any'. </summary>
        public FirewallBooleanType? NegateSource { get; set; }
        /// <summary> destination address. </summary>
        public DestinationAddressInfo Destination { get; set; }
        /// <summary> cidr should not be 'any'. </summary>
        public FirewallBooleanType? NegateDestination { get; set; }
        /// <summary> array of rule applications. </summary>
        public IList<string> Applications { get; }
        /// <summary> rule category. </summary>
        public EdlMatchCategory Category { get; set; }
        /// <summary> any, application-default, TCP:number, UDP:number. </summary>
        public string Protocol { get; set; }
        /// <summary> prot port list. </summary>
        public IList<string> ProtocolPortList { get; }
        /// <summary> inbound Inspection Certificate. </summary>
        public string InboundInspectionCertificate { get; set; }
        /// <summary> rule comment. </summary>
        public string AuditComment { get; set; }
        /// <summary> rule action. </summary>
        public RulestackActionType? ActionType { get; set; }
        /// <summary> enable or disable logging. </summary>
        public RulestackStateType? EnableLogging { get; set; }
        /// <summary> enable or disable decryption. </summary>
        public DecryptionRuleType? DecryptionRuleType { get; set; }
        /// <summary> tag for rule. </summary>
        public IList<RulestackTagInfo> Tags { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public FirewallProvisioningState? ProvisioningState { get; }
    }
}
