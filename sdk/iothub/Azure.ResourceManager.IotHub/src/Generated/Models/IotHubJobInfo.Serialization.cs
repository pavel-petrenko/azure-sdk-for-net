// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubJobInfo : IUtf8JsonSerializable, IJsonModel<IotHubJobInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubJobInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IotHubJobInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubJobInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubJobInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTimeUtc"u8);
                writer.WriteStringValue(StartOn.Value, "R");
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTimeUtc"u8);
                writer.WriteStringValue(EndOn.Value, "R");
            }
            if (options.Format != "W" && Optional.IsDefined(JobType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(JobType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(FailureReason))
            {
                writer.WritePropertyName("failureReason"u8);
                writer.WriteStringValue(FailureReason);
            }
            if (options.Format != "W" && Optional.IsDefined(StatusMessage))
            {
                writer.WritePropertyName("statusMessage"u8);
                writer.WriteStringValue(StatusMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(ParentJobId))
            {
                writer.WritePropertyName("parentJobId"u8);
                writer.WriteStringValue(ParentJobId);
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

        IotHubJobInfo IJsonModel<IotHubJobInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubJobInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubJobInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubJobInfo(document.RootElement, options);
        }

        internal static IotHubJobInfo DeserializeIotHubJobInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> jobId = default;
            Optional<DateTimeOffset> startTimeUtc = default;
            Optional<DateTimeOffset> endTimeUtc = default;
            Optional<IotHubJobType> type = default;
            Optional<IotHubJobStatus> status = default;
            Optional<string> failureReason = default;
            Optional<string> statusMessage = default;
            Optional<string> parentJobId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTimeUtc = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("endTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTimeUtc = property.Value.GetDateTimeOffset("R");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new IotHubJobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToIotHubJobStatus();
                    continue;
                }
                if (property.NameEquals("failureReason"u8))
                {
                    failureReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    statusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parentJobId"u8))
                {
                    parentJobId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotHubJobInfo(jobId.Value, Optional.ToNullable(startTimeUtc), Optional.ToNullable(endTimeUtc), Optional.ToNullable(type), Optional.ToNullable(status), failureReason.Value, statusMessage.Value, parentJobId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubJobInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubJobInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotHubJobInfo)} does not support '{options.Format}' format.");
            }
        }

        IotHubJobInfo IPersistableModel<IotHubJobInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubJobInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotHubJobInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubJobInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubJobInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
