// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Chat
{
    public partial class UserChatMessage : IJsonModel<UserChatMessage>
    {
        UserChatMessage IJsonModel<UserChatMessage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserChatMessage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserChatMessage)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserChatMessage(document.RootElement, options);
        }

        internal static UserChatMessage DeserializeUserChatMessage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ChatMessageRole role = default;
            ChatMessageContent content = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    role = property.Value.GetString().ToChatMessageRole();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    DeserializeContentValue(property, ref content);
                    continue;
                }
                if (true)
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            // CUSTOM: Initialize Content collection property.
            return new UserChatMessage(role, content ?? new ChatMessageContent(), serializedAdditionalRawData, name);
        }

        BinaryData IPersistableModel<UserChatMessage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserChatMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UserChatMessage)} does not support writing '{options.Format}' format.");
            }
        }

        UserChatMessage IPersistableModel<UserChatMessage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserChatMessage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUserChatMessage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserChatMessage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserChatMessage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new UserChatMessage FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUserChatMessage(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
