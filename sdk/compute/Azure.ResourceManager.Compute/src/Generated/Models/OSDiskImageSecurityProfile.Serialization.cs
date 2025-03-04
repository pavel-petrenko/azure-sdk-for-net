// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class OSDiskImageSecurityProfile : IUtf8JsonSerializable, IJsonModel<OSDiskImageSecurityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OSDiskImageSecurityProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OSDiskImageSecurityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSDiskImageSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSDiskImageSecurityProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ConfidentialVmEncryptionType))
            {
                writer.WritePropertyName("confidentialVMEncryptionType"u8);
                writer.WriteStringValue(ConfidentialVmEncryptionType.Value.ToString());
            }
            if (Optional.IsDefined(SecureVmDiskEncryptionSetId))
            {
                writer.WritePropertyName("secureVMDiskEncryptionSetId"u8);
                writer.WriteStringValue(SecureVmDiskEncryptionSetId);
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

        OSDiskImageSecurityProfile IJsonModel<OSDiskImageSecurityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSDiskImageSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSDiskImageSecurityProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOSDiskImageSecurityProfile(document.RootElement, options);
        }

        internal static OSDiskImageSecurityProfile DeserializeOSDiskImageSecurityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ConfidentialVmEncryptionType> confidentialVmEncryptionType = default;
            Optional<string> secureVmDiskEncryptionSetId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("confidentialVMEncryptionType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidentialVmEncryptionType = new ConfidentialVmEncryptionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secureVMDiskEncryptionSetId"u8))
                {
                    secureVmDiskEncryptionSetId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OSDiskImageSecurityProfile(Optional.ToNullable(confidentialVmEncryptionType), secureVmDiskEncryptionSetId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OSDiskImageSecurityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSDiskImageSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OSDiskImageSecurityProfile)} does not support '{options.Format}' format.");
            }
        }

        OSDiskImageSecurityProfile IPersistableModel<OSDiskImageSecurityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSDiskImageSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOSDiskImageSecurityProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OSDiskImageSecurityProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OSDiskImageSecurityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
