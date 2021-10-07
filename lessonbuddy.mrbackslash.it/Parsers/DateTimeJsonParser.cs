using System;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace lessonbuddy.mrbackslash.it.Parsers
{
    public class DateTimeJsonParser : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Debug.Assert(typeToConvert == typeof(DateTime));
            return DateTime.ParseExact(reader.GetString(), "yyyy-MM-ddTHH:mm:ss:fff", null);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
