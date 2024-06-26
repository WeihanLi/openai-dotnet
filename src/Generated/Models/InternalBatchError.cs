// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Batch
{
    internal partial class InternalBatchError
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalBatchError()
        {
        }

        internal InternalBatchError(string code, string message, string param, int? line, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            Param = param;
            Line = line;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public string Code { get; }
        public string Message { get; }
        public string Param { get; }
        public int? Line { get; }
    }
}
