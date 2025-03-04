// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformUploadedUserSourceInfo : IUtf8JsonSerializable, IJsonModel<AppPlatformUploadedUserSourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformUploadedUserSourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformUploadedUserSourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformUploadedUserSourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RelativePath))
            {
                writer.WritePropertyName("relativePath"u8);
                writer.WriteStringValue(RelativePath);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(UserSourceInfoType);
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
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

        AppPlatformUploadedUserSourceInfo IJsonModel<AppPlatformUploadedUserSourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformUploadedUserSourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformUploadedUserSourceInfo(document.RootElement, options);
        }

        internal static AppPlatformUploadedUserSourceInfo DeserializeAppPlatformUploadedUserSourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Jar": return JarUploadedUserSourceInfo.DeserializeJarUploadedUserSourceInfo(element);
                    case "NetCoreZip": return NetCoreZipUploadedUserSourceInfo.DeserializeNetCoreZipUploadedUserSourceInfo(element);
                    case "Source": return SourceUploadedUserSourceInfo.DeserializeSourceUploadedUserSourceInfo(element);
                }
            }
            Optional<string> relativePath = default;
            string type = "UploadedUserSourceInfo";
            Optional<string> version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relativePath"u8))
                {
                    relativePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformUploadedUserSourceInfo(type, version.Value, serializedAdditionalRawData, relativePath.Value);
        }

        BinaryData IPersistableModel<AppPlatformUploadedUserSourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformUploadedUserSourceInfo)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformUploadedUserSourceInfo IPersistableModel<AppPlatformUploadedUserSourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformUploadedUserSourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformUploadedUserSourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformUploadedUserSourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformUploadedUserSourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
