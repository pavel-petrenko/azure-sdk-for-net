// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DefaultAuthorizationPolicy : IUtf8JsonSerializable, IJsonModel<DefaultAuthorizationPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefaultAuthorizationPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefaultAuthorizationPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefaultAuthorizationPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AllowedPrincipals))
            {
                writer.WritePropertyName("allowedPrincipals"u8);
                writer.WriteObjectValue(AllowedPrincipals);
            }
            if (Optional.IsCollectionDefined(AllowedApplications))
            {
                writer.WritePropertyName("allowedApplications"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedApplications)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        DefaultAuthorizationPolicy IJsonModel<DefaultAuthorizationPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefaultAuthorizationPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefaultAuthorizationPolicy(document.RootElement, options);
        }

        internal static DefaultAuthorizationPolicy DeserializeDefaultAuthorizationPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppServiceAadAllowedPrincipals> allowedPrincipals = default;
            Optional<IList<string>> allowedApplications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedPrincipals"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowedPrincipals = AppServiceAadAllowedPrincipals.DeserializeAppServiceAadAllowedPrincipals(property.Value);
                    continue;
                }
                if (property.NameEquals("allowedApplications"u8))
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
                    allowedApplications = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefaultAuthorizationPolicy(allowedPrincipals.Value, Optional.ToList(allowedApplications), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefaultAuthorizationPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefaultAuthorizationPolicy)} does not support '{options.Format}' format.");
            }
        }

        DefaultAuthorizationPolicy IPersistableModel<DefaultAuthorizationPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefaultAuthorizationPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefaultAuthorizationPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefaultAuthorizationPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefaultAuthorizationPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
