// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    internal partial class InternalChatResponseFormatText : ChatResponseFormat
    {
        public InternalChatResponseFormatText()
        {
            Type = "text";
        }

        internal InternalChatResponseFormatText(string type, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(type, serializedAdditionalRawData)
        {
        }
    }
}
