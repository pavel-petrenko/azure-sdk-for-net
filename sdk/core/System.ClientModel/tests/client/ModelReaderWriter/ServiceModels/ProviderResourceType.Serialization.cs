// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using ClientModel.Tests.ClientShared;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace System.ClientModel.Tests.Client.Models.ResourceManager.Resources
{
    public partial class ProviderResourceType : IJsonModel<ProviderResourceType>
    {
        internal static ProviderResourceType DeserializeProviderResourceType(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterHelper.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptionalProperty<string> resourceType = default;
            OptionalProperty<IReadOnlyList<string>> locations = default;
            OptionalProperty<IReadOnlyList<ProviderExtendedLocation>> locationMappings = default;
            OptionalProperty<IReadOnlyList<ResourceTypeAlias>> aliases = default;
            OptionalProperty<IReadOnlyList<string>> apiVersions = default;
            OptionalProperty<string> defaultApiVersion = default;
            OptionalProperty<IReadOnlyList<ZoneMapping>> zoneMappings = default;
            OptionalProperty<IReadOnlyList<ApiProfile>> apiProfiles = default;
            OptionalProperty<string> capabilities = default;
            OptionalProperty<IReadOnlyDictionary<string, string>> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
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
                    locations = array;
                    continue;
                }
                if (property.NameEquals("locationMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderExtendedLocation> array = new List<ProviderExtendedLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderExtendedLocation.DeserializeProviderExtendedLocation(item, options));
                    }
                    locationMappings = array;
                    continue;
                }
                if (property.NameEquals("aliases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceTypeAlias> array = new List<ResourceTypeAlias>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceTypeAlias.DeserializeResourceTypeAlias(item, options));
                    }
                    aliases = array;
                    continue;
                }
                if (property.NameEquals("apiVersions"u8))
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
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("defaultApiVersion"u8))
                {
                    defaultApiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zoneMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ZoneMapping> array = new List<ZoneMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ZoneMapping.DeserializeZoneMapping(item, options));
                    }
                    zoneMappings = array;
                    continue;
                }
                if (property.NameEquals("apiProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiProfile> array = new List<ApiProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiProfile.DeserializeApiProfile(item, options));
                    }
                    apiProfiles = array;
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    capabilities = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
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
                    properties = dictionary;
                    continue;
                }
            }
            return new ProviderResourceType(resourceType.Value, OptionalProperty.ToList(locations), OptionalProperty.ToList(locationMappings), OptionalProperty.ToList(aliases), OptionalProperty.ToList(apiVersions), defaultApiVersion.Value, OptionalProperty.ToList(zoneMappings), OptionalProperty.ToList(apiProfiles), capabilities.Value, OptionalProperty.ToDictionary(properties));
        }

        void IJsonModel<ProviderResourceType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if(OptionalProperty.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (OptionalProperty.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (OptionalProperty.IsCollectionDefined(ApiVersions))
            {
                writer.WritePropertyName("apiVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ApiVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (OptionalProperty.IsDefined(DefaultApiVersion))
            {
                writer.WritePropertyName("defaultApiVersion"u8);
                writer.WriteStringValue(DefaultApiVersion);
            }
            if (OptionalProperty.IsCollectionDefined(ApiProfiles))
            {
                writer.WritePropertyName("apiProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ApiProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OptionalProperty.IsCollectionDefined(ZoneMappings))
            {
                writer.WritePropertyName("zoneMappings"u8);
                writer.WriteStartArray();
                foreach (var item in ZoneMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OptionalProperty.IsCollectionDefined(LocationMappings))
            {
                writer.WritePropertyName("locationMappings"u8);
                writer.WriteStartArray();
                foreach (var item in LocationMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OptionalProperty.IsDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStringValue(Capabilities);
            }
            if (OptionalProperty.IsCollectionDefined(Aliases))
            {
                writer.WritePropertyName("aliases"u8);
                writer.WriteStartArray();
                foreach (var item in Aliases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OptionalProperty.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        private struct ProviderResourceTypeProperties
        {
            public OptionalProperty<string> ResourceType { get; set; }
            public OptionalProperty<IReadOnlyList<string>> Locations { get; set; }
            public OptionalProperty<IReadOnlyList<ProviderExtendedLocation>> LocationMappings { get; set; }
            public OptionalProperty<IReadOnlyList<ResourceTypeAlias>> Aliases { get; set; }
            public OptionalProperty<IReadOnlyList<string>> ApiVersions { get; set; }
            public OptionalProperty<string> DefaultApiVersion { get; set; }
            public OptionalProperty<IReadOnlyList<ZoneMapping>> ZoneMappings { get; set; }
            public OptionalProperty<IReadOnlyList<ApiProfile>> ApiProfiles { get; set; }
            public OptionalProperty<string> Capabilities { get; set; }
            public OptionalProperty<IReadOnlyDictionary<string, string>> Properties { get; set; }
        }

        ProviderResourceType IJsonModel<ProviderResourceType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderResourceType(doc.RootElement, options);
        }

        ProviderResourceType IPersistableModel<ProviderResourceType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeProviderResourceType(doc.RootElement, options);
        }

        BinaryData IPersistableModel<ProviderResourceType>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        string IPersistableModel<ProviderResourceType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
