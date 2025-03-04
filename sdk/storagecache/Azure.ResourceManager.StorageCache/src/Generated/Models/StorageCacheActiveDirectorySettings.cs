// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Active Directory settings used to join a cache to a domain. </summary>
    public partial class StorageCacheActiveDirectorySettings
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

        /// <summary> Initializes a new instance of <see cref="StorageCacheActiveDirectorySettings"/>. </summary>
        /// <param name="primaryDnsIPAddress"> Primary DNS IP address used to resolve the Active Directory domain controller's fully qualified domain name. </param>
        /// <param name="domainName"> The fully qualified domain name of the Active Directory domain controller. </param>
        /// <param name="domainNetBiosName"> The Active Directory domain's NetBIOS name. </param>
        /// <param name="cacheNetBiosName"> The NetBIOS name to assign to the HPC Cache when it joins the Active Directory domain as a server. Length must 1-15 characters from the class [-0-9a-zA-Z]. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="primaryDnsIPAddress"/>, <paramref name="domainName"/>, <paramref name="domainNetBiosName"/> or <paramref name="cacheNetBiosName"/> is null. </exception>
        public StorageCacheActiveDirectorySettings(IPAddress primaryDnsIPAddress, string domainName, string domainNetBiosName, string cacheNetBiosName)
        {
            Argument.AssertNotNull(primaryDnsIPAddress, nameof(primaryDnsIPAddress));
            Argument.AssertNotNull(domainName, nameof(domainName));
            Argument.AssertNotNull(domainNetBiosName, nameof(domainNetBiosName));
            Argument.AssertNotNull(cacheNetBiosName, nameof(cacheNetBiosName));

            PrimaryDnsIPAddress = primaryDnsIPAddress;
            DomainName = domainName;
            DomainNetBiosName = domainNetBiosName;
            CacheNetBiosName = cacheNetBiosName;
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheActiveDirectorySettings"/>. </summary>
        /// <param name="primaryDnsIPAddress"> Primary DNS IP address used to resolve the Active Directory domain controller's fully qualified domain name. </param>
        /// <param name="secondaryDnsIPAddress"> Secondary DNS IP address used to resolve the Active Directory domain controller's fully qualified domain name. </param>
        /// <param name="domainName"> The fully qualified domain name of the Active Directory domain controller. </param>
        /// <param name="domainNetBiosName"> The Active Directory domain's NetBIOS name. </param>
        /// <param name="cacheNetBiosName"> The NetBIOS name to assign to the HPC Cache when it joins the Active Directory domain as a server. Length must 1-15 characters from the class [-0-9a-zA-Z]. </param>
        /// <param name="domainJoined"> True if the HPC Cache is joined to the Active Directory domain. </param>
        /// <param name="credentials"> Active Directory admin credentials used to join the HPC Cache to a domain. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCacheActiveDirectorySettings(IPAddress primaryDnsIPAddress, IPAddress secondaryDnsIPAddress, string domainName, string domainNetBiosName, string cacheNetBiosName, DomainJoinedType? domainJoined, StorageCacheActiveDirectorySettingsCredentials credentials, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrimaryDnsIPAddress = primaryDnsIPAddress;
            SecondaryDnsIPAddress = secondaryDnsIPAddress;
            DomainName = domainName;
            DomainNetBiosName = domainNetBiosName;
            CacheNetBiosName = cacheNetBiosName;
            DomainJoined = domainJoined;
            Credentials = credentials;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageCacheActiveDirectorySettings"/> for deserialization. </summary>
        internal StorageCacheActiveDirectorySettings()
        {
        }

        /// <summary> Primary DNS IP address used to resolve the Active Directory domain controller's fully qualified domain name. </summary>
        public IPAddress PrimaryDnsIPAddress { get; set; }
        /// <summary> Secondary DNS IP address used to resolve the Active Directory domain controller's fully qualified domain name. </summary>
        public IPAddress SecondaryDnsIPAddress { get; set; }
        /// <summary> The fully qualified domain name of the Active Directory domain controller. </summary>
        public string DomainName { get; set; }
        /// <summary> The Active Directory domain's NetBIOS name. </summary>
        public string DomainNetBiosName { get; set; }
        /// <summary> The NetBIOS name to assign to the HPC Cache when it joins the Active Directory domain as a server. Length must 1-15 characters from the class [-0-9a-zA-Z]. </summary>
        public string CacheNetBiosName { get; set; }
        /// <summary> True if the HPC Cache is joined to the Active Directory domain. </summary>
        public DomainJoinedType? DomainJoined { get; }
        /// <summary> Active Directory admin credentials used to join the HPC Cache to a domain. </summary>
        public StorageCacheActiveDirectorySettingsCredentials Credentials { get; set; }
    }
}
