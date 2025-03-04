// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class LinkableEnvironmentResult : IUtf8JsonSerializable, IJsonModel<LinkableEnvironmentResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkableEnvironmentResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LinkableEnvironmentResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkableEnvironmentResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkableEnvironmentResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId"u8);
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsDefined(EnvironmentName))
            {
                writer.WritePropertyName("environmentName"u8);
                writer.WriteStringValue(EnvironmentName);
            }
            if (Optional.IsDefined(PlanData))
            {
                writer.WritePropertyName("planData"u8);
                writer.WriteObjectValue(PlanData);
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

        LinkableEnvironmentResult IJsonModel<LinkableEnvironmentResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkableEnvironmentResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkableEnvironmentResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkableEnvironmentResult(document.RootElement, options);
        }

        internal static LinkableEnvironmentResult DeserializeLinkableEnvironmentResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> environmentId = default;
            Optional<string> environmentName = default;
            Optional<DynatraceBillingPlanInfo> planData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("environmentId"u8))
                {
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentName"u8))
                {
                    environmentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    planData = DynatraceBillingPlanInfo.DeserializeDynatraceBillingPlanInfo(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinkableEnvironmentResult(environmentId.Value, environmentName.Value, planData.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinkableEnvironmentResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkableEnvironmentResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinkableEnvironmentResult)} does not support '{options.Format}' format.");
            }
        }

        LinkableEnvironmentResult IPersistableModel<LinkableEnvironmentResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkableEnvironmentResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLinkableEnvironmentResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinkableEnvironmentResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinkableEnvironmentResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
