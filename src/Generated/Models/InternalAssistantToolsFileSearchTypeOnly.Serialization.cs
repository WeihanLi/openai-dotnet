// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI.Internal.Models;

namespace OpenAI.Internal.Assistants
{
    internal partial struct InternalAssistantToolsFileSearchTypeOnly : IJsonModel<InternalAssistantToolsFileSearchTypeOnly>, IJsonModel<object>
    {
        void IJsonModel<InternalAssistantToolsFileSearchTypeOnly>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAssistantToolsFileSearchTypeOnly>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAssistantToolsFileSearchTypeOnly)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (true && _serializedAdditionalRawData != null)
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

        InternalAssistantToolsFileSearchTypeOnly IJsonModel<InternalAssistantToolsFileSearchTypeOnly>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAssistantToolsFileSearchTypeOnly>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalAssistantToolsFileSearchTypeOnly)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalAssistantToolsFileSearchTypeOnly(document.RootElement, options);
        }

        void IJsonModel<object>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<InternalAssistantToolsFileSearchTypeOnly>)this).Write(writer, options);

        object IJsonModel<object>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<InternalAssistantToolsFileSearchTypeOnly>)this).Create(ref reader, options);

        internal static InternalAssistantToolsFileSearchTypeOnly DeserializeInternalAssistantToolsFileSearchTypeOnly(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            AssistantToolsFileSearchTypeOnlyType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new AssistantToolsFileSearchTypeOnlyType(property.Value.GetString());
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalAssistantToolsFileSearchTypeOnly(type, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InternalAssistantToolsFileSearchTypeOnly>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAssistantToolsFileSearchTypeOnly>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalAssistantToolsFileSearchTypeOnly)} does not support writing '{options.Format}' format.");
            }
        }

        InternalAssistantToolsFileSearchTypeOnly IPersistableModel<InternalAssistantToolsFileSearchTypeOnly>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalAssistantToolsFileSearchTypeOnly>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalAssistantToolsFileSearchTypeOnly(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalAssistantToolsFileSearchTypeOnly)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalAssistantToolsFileSearchTypeOnly>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        BinaryData IPersistableModel<object>.Write(ModelReaderWriterOptions options) => ((IPersistableModel<InternalAssistantToolsFileSearchTypeOnly>)this).Write(options);

        object IPersistableModel<object>.Create(BinaryData data, ModelReaderWriterOptions options) => ((IPersistableModel<InternalAssistantToolsFileSearchTypeOnly>)this).Create(data, options);

        string IPersistableModel<object>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<InternalAssistantToolsFileSearchTypeOnly>)this).GetFormatFromOptions(options);

        internal static InternalAssistantToolsFileSearchTypeOnly FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalAssistantToolsFileSearchTypeOnly(document.RootElement);
        }

        internal BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}