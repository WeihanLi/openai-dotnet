// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationOutputTokenUsageDetails
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal ConversationOutputTokenUsageDetails(int textTokens, int audioTokens)
        {
            TextTokens = textTokens;
            AudioTokens = audioTokens;
        }

        internal ConversationOutputTokenUsageDetails(int textTokens, int audioTokens, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TextTokens = textTokens;
            AudioTokens = audioTokens;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal ConversationOutputTokenUsageDetails()
        {
        }

        public int TextTokens { get; }
        public int AudioTokens { get; }
    }
}
