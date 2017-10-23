using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Syncromatics.Clients.WaySine
{
    public class PolledDateTimeConverter : DateTimeConverterBase
    {
        public override bool CanWrite => false;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.Integer) return null;
            var ticks = (long)reader.Value;
            return new DateTime(1970, 1, 1).AddMilliseconds(ticks);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
