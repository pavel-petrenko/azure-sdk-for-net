// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RedisEnterprise.Models;

namespace Azure.ResourceManager.RedisEnterprise
{
    public partial class RedisEnterpriseClusterData : IUtf8JsonSerializable, IJsonModel<RedisEnterpriseClusterData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedisEnterpriseClusterData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedisEnterpriseClusterData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseClusterData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (options.Format != "W" && Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceState))
            {
                writer.WritePropertyName("resourceState"u8);
                writer.WriteStringValue(ResourceState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(RedisVersion))
            {
                writer.WritePropertyName("redisVersion"u8);
                writer.WriteStringValue(RedisVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RedisEnterpriseClusterData IJsonModel<RedisEnterpriseClusterData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseClusterData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedisEnterpriseClusterData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisEnterpriseClusterData(document.RootElement, options);
        }

        internal static RedisEnterpriseClusterData DeserializeRedisEnterpriseClusterData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RedisEnterpriseSku sku = default;
            Optional<IList<string>> zones = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<RedisEnterpriseTlsVersion> minimumTlsVersion = default;
            Optional<ClusterPropertiesEncryption> encryption = default;
            Optional<string> hostName = default;
            Optional<RedisEnterpriseProvisioningStatus> provisioningState = default;
            Optional<RedisEnterpriseClusterResourceState> resourceState = default;
            Optional<string> redisVersion = default;
            Optional<IReadOnlyList<RedisEnterprisePrivateEndpointConnectionData>> privateEndpointConnections = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = RedisEnterpriseSku.DeserializeRedisEnterpriseSku(property.Value);
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("minimumTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersion = new RedisEnterpriseTlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = ClusterPropertiesEncryption.DeserializeClusterPropertiesEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hostName"u8))
                        {
                            hostName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new RedisEnterpriseProvisioningStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new RedisEnterpriseClusterResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("redisVersion"u8))
                        {
                            redisVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RedisEnterprisePrivateEndpointConnectionData> array = new List<RedisEnterprisePrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RedisEnterprisePrivateEndpointConnectionData.DeserializeRedisEnterprisePrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedisEnterpriseClusterData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku, Optional.ToList(zones), identity, Optional.ToNullable(minimumTlsVersion), encryption.Value, hostName.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(resourceState), redisVersion.Value, Optional.ToList(privateEndpointConnections), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedisEnterpriseClusterData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseClusterData)} does not support '{options.Format}' format.");
            }
        }

        RedisEnterpriseClusterData IPersistableModel<RedisEnterpriseClusterData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedisEnterpriseClusterData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedisEnterpriseClusterData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedisEnterpriseClusterData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedisEnterpriseClusterData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
