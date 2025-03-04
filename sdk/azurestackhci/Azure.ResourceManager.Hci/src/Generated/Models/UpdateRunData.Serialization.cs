// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class UpdateRunData : IUtf8JsonSerializable, IJsonModel<UpdateRunData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateRunData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpdateRunData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateRunData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
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
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(TimeStarted))
            {
                writer.WritePropertyName("timeStarted"u8);
                writer.WriteStringValue(TimeStarted.Value, "O");
            }
            if (Optional.IsDefined(LastUpdatedOn))
            {
                writer.WritePropertyName("lastUpdatedTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WritePropertyName("progress"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(NamePropertiesProgressName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(NamePropertiesProgressName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(StartTimeUtc))
            {
                writer.WritePropertyName("startTimeUtc"u8);
                writer.WriteStringValue(StartTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(EndTimeUtc))
            {
                writer.WritePropertyName("endTimeUtc"u8);
                writer.WriteStringValue(EndTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(LastUpdatedTimeUtc))
            {
                writer.WritePropertyName("lastUpdatedTimeUtc"u8);
                writer.WriteStringValue(LastUpdatedTimeUtc.Value, "O");
            }
            if (Optional.IsCollectionDefined(Steps))
            {
                writer.WritePropertyName("steps"u8);
                writer.WriteStartArray();
                foreach (var item in Steps)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        UpdateRunData IJsonModel<UpdateRunData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateRunData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateRunData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateRunData(document.RootElement, options);
        }

        internal static UpdateRunData DeserializeUpdateRunData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<HciProvisioningState> provisioningState = default;
            Optional<DateTimeOffset> timeStarted = default;
            Optional<DateTimeOffset> lastUpdatedTime = default;
            Optional<string> duration = default;
            Optional<UpdateRunPropertiesState> state = default;
            Optional<string> name0 = default;
            Optional<string> description = default;
            Optional<string> errorMessage = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> startTimeUtc = default;
            Optional<DateTimeOffset> endTimeUtc = default;
            Optional<DateTimeOffset> lastUpdatedTimeUtc = default;
            Optional<IList<HciUpdateStep>> steps = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HciProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("timeStarted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeStarted = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("duration"u8))
                        {
                            duration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new UpdateRunPropertiesState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("progress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("name"u8))
                                {
                                    name0 = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("description"u8))
                                {
                                    description = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("errorMessage"u8))
                                {
                                    errorMessage = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("status"u8))
                                {
                                    status = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("startTimeUtc"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    startTimeUtc = property1.Value.GetDateTimeOffset("O");
                                    continue;
                                }
                                if (property1.NameEquals("endTimeUtc"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    endTimeUtc = property1.Value.GetDateTimeOffset("O");
                                    continue;
                                }
                                if (property1.NameEquals("lastUpdatedTimeUtc"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    lastUpdatedTimeUtc = property1.Value.GetDateTimeOffset("O");
                                    continue;
                                }
                                if (property1.NameEquals("steps"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    List<HciUpdateStep> array = new List<HciUpdateStep>();
                                    foreach (var item in property1.Value.EnumerateArray())
                                    {
                                        array.Add(HciUpdateStep.DeserializeHciUpdateStep(item));
                                    }
                                    steps = array;
                                    continue;
                                }
                            }
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
            return new UpdateRunData(id, name, type, systemData.Value, Optional.ToNullable(location), Optional.ToNullable(provisioningState), Optional.ToNullable(timeStarted), Optional.ToNullable(lastUpdatedTime), duration.Value, Optional.ToNullable(state), name0.Value, description.Value, errorMessage.Value, status.Value, Optional.ToNullable(startTimeUtc), Optional.ToNullable(endTimeUtc), Optional.ToNullable(lastUpdatedTimeUtc), Optional.ToList(steps), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateRunData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateRunData)} does not support '{options.Format}' format.");
            }
        }

        UpdateRunData IPersistableModel<UpdateRunData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateRunData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdateRunData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateRunData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateRunData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
