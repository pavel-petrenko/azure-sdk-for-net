// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    public partial class CosmosDBForPostgreSqlPrivateLinkServiceConnectionState : IUtf8JsonSerializable, IJsonModel<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlPrivateLinkServiceConnectionState)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ActionsRequired))
            {
                writer.WritePropertyName("actionsRequired"u8);
                writer.WriteStringValue(ActionsRequired);
            }
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

        CosmosDBForPostgreSqlPrivateLinkServiceConnectionState IJsonModel<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlPrivateLinkServiceConnectionState)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBForPostgreSqlPrivateLinkServiceConnectionState(document.RootElement, options);
        }

        internal static CosmosDBForPostgreSqlPrivateLinkServiceConnectionState DeserializeCosmosDBForPostgreSqlPrivateLinkServiceConnectionState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CosmosDBForPostgreSqlPrivateEndpointServiceConnectionStatus> status = default;
            Optional<string> description = default;
            Optional<string> actionsRequired = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new CosmosDBForPostgreSqlPrivateEndpointServiceConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"u8))
                {
                    actionsRequired = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBForPostgreSqlPrivateLinkServiceConnectionState(Optional.ToNullable(status), description.Value, actionsRequired.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlPrivateLinkServiceConnectionState)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBForPostgreSqlPrivateLinkServiceConnectionState IPersistableModel<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBForPostgreSqlPrivateLinkServiceConnectionState(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBForPostgreSqlPrivateLinkServiceConnectionState)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBForPostgreSqlPrivateLinkServiceConnectionState>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
