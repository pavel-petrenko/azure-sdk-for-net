// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceProviderManagement. </summary>
    public partial class ResourceProviderManagement
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

        /// <summary> Initializes a new instance of <see cref="ResourceProviderManagement"/>. </summary>
        public ResourceProviderManagement()
        {
            SchemaOwners = new ChangeTrackingList<string>();
            ManifestOwners = new ChangeTrackingList<string>();
            ServiceTreeInfos = new ChangeTrackingList<ServiceTreeInfo>();
            ResourceAccessRoles = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceProviderManagement"/>. </summary>
        /// <param name="schemaOwners"></param>
        /// <param name="manifestOwners"></param>
        /// <param name="incidentRoutingService"></param>
        /// <param name="incidentRoutingTeam"></param>
        /// <param name="incidentContactEmail"></param>
        /// <param name="serviceTreeInfos"></param>
        /// <param name="resourceAccessPolicy"></param>
        /// <param name="resourceAccessRoles"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceProviderManagement(IList<string> schemaOwners, IList<string> manifestOwners, string incidentRoutingService, string incidentRoutingTeam, string incidentContactEmail, IList<ServiceTreeInfo> serviceTreeInfos, ResourceAccessPolicy? resourceAccessPolicy, IList<BinaryData> resourceAccessRoles, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SchemaOwners = schemaOwners;
            ManifestOwners = manifestOwners;
            IncidentRoutingService = incidentRoutingService;
            IncidentRoutingTeam = incidentRoutingTeam;
            IncidentContactEmail = incidentContactEmail;
            ServiceTreeInfos = serviceTreeInfos;
            ResourceAccessPolicy = resourceAccessPolicy;
            ResourceAccessRoles = resourceAccessRoles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the schema owners. </summary>
        public IList<string> SchemaOwners { get; }
        /// <summary> Gets the manifest owners. </summary>
        public IList<string> ManifestOwners { get; }
        /// <summary> Gets or sets the incident routing service. </summary>
        public string IncidentRoutingService { get; set; }
        /// <summary> Gets or sets the incident routing team. </summary>
        public string IncidentRoutingTeam { get; set; }
        /// <summary> Gets or sets the incident contact email. </summary>
        public string IncidentContactEmail { get; set; }
        /// <summary> Gets the service tree infos. </summary>
        public IList<ServiceTreeInfo> ServiceTreeInfos { get; }
        /// <summary> Gets or sets the resource access policy. </summary>
        public ResourceAccessPolicy? ResourceAccessPolicy { get; set; }
        /// <summary>
        /// Gets the resource access roles
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> ResourceAccessRoles { get; }
    }
}
