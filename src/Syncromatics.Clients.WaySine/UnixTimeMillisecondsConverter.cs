using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Syncromatics.Clients.WaySine
{
    public class UnixTimeMillisecondsConverter : DateTimeConverterBase
    {
        public override bool CanWrite => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Integer) return null;
            var milliseconds = (long)reader.Value;
            return DateTimeOffset.FromUnixTimeMilliseconds(milliseconds);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
