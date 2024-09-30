// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Chat
{
    public readonly partial struct ChatImageDetailLevel : IEquatable<ChatImageDetailLevel>
    {
        private readonly string _value;

        public ChatImageDetailLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";
        private const string LowValue = "low";
        private const string HighValue = "high";

        public static ChatImageDetailLevel Auto { get; } = new ChatImageDetailLevel(AutoValue);
        public static ChatImageDetailLevel Low { get; } = new ChatImageDetailLevel(LowValue);
        public static ChatImageDetailLevel High { get; } = new ChatImageDetailLevel(HighValue);
        public static bool operator ==(ChatImageDetailLevel left, ChatImageDetailLevel right) => left.Equals(right);
        public static bool operator !=(ChatImageDetailLevel left, ChatImageDetailLevel right) => !left.Equals(right);
        public static implicit operator ChatImageDetailLevel(string value) => new ChatImageDetailLevel(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChatImageDetailLevel other && Equals(other);
        public bool Equals(ChatImageDetailLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}