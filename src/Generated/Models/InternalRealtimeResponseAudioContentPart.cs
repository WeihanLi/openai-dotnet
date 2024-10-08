// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    internal partial class InternalRealtimeResponseAudioContentPart : ConversationContentPart
    {
        internal InternalRealtimeResponseAudioContentPart(string transcript)
        {
            Type = ConversationContentPartKind.Audio;
            Transcript = transcript;
        }

        internal InternalRealtimeResponseAudioContentPart(ConversationContentPartKind type, IDictionary<string, BinaryData> serializedAdditionalRawData, string transcript) : base(type, serializedAdditionalRawData)
        {
            Transcript = transcript;
        }

        internal InternalRealtimeResponseAudioContentPart()
        {
        }

        public string Transcript { get; }
    }
}
