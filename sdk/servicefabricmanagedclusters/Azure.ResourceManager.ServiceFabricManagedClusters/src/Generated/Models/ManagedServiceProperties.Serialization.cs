// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedServiceProperties : IUtf8JsonSerializable, IJsonModel<ManagedServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServiceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedServiceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServiceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            writer.WritePropertyName("serviceKind"u8);
            writer.WriteStringValue(ServiceKind.ToString());
            writer.WritePropertyName("serviceTypeName"u8);
            writer.WriteStringValue(ServiceTypeName);
            writer.WritePropertyName("partitionDescription"u8);
            writer.WriteObjectValue(PartitionDescription);
            if (Optional.IsDefined(ServicePackageActivationMode))
            {
                writer.WritePropertyName("servicePackageActivationMode"u8);
                writer.WriteStringValue(ServicePackageActivationMode.Value.ToString());
            }
            if (Optional.IsDefined(ServiceDnsName))
            {
                writer.WritePropertyName("serviceDnsName"u8);
                writer.WriteStringValue(ServiceDnsName);
            }
            if (Optional.IsDefined(PlacementConstraints))
            {
                writer.WritePropertyName("placementConstraints"u8);
                writer.WriteStringValue(PlacementConstraints);
            }
            if (Optional.IsCollectionDefined(CorrelationScheme))
            {
                writer.WritePropertyName("correlationScheme"u8);
                writer.WriteStartArray();
                foreach (var item in CorrelationScheme)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServiceLoadMetrics))
            {
                writer.WritePropertyName("serviceLoadMetrics"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceLoadMetrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ServicePlacementPolicies))
            {
                writer.WritePropertyName("servicePlacementPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ServicePlacementPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultMoveCost))
            {
                writer.WritePropertyName("defaultMoveCost"u8);
                writer.WriteStringValue(DefaultMoveCost.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ScalingPolicies))
            {
                writer.WritePropertyName("scalingPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ScalingPolicies)
                {
                    writer.WriteObjectValue(item);
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

        ManagedServiceProperties IJsonModel<ManagedServiceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServiceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServiceProperties(document.RootElement, options);
        }

        internal static ManagedServiceProperties DeserializeManagedServiceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("serviceKind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Stateful": return StatefulServiceProperties.DeserializeStatefulServiceProperties(element);
                    case "Stateless": return StatelessServiceProperties.DeserializeStatelessServiceProperties(element);
                }
            }
            return UnknownServiceResourceProperties.DeserializeUnknownServiceResourceProperties(element);
        }

        BinaryData IPersistableModel<ManagedServiceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        ManagedServiceProperties IPersistableModel<ManagedServiceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedServiceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedServiceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServiceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
