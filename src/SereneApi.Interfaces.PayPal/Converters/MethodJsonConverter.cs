using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.Converters
{
    internal class MethodJsonConverter: JsonConverter<Method>
    {
        public override Method Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() switch
            {
                "DELETE" => Method.DELETE,
                "GET" => Method.GET,
                "PATCH" => Method.PATCH,
                "POST" => Method.POST,
                "PUT" => Method.PUT,
                _ => Method.NONE
            };
        }

        public override void Write(Utf8JsonWriter writer, Method value, JsonSerializerOptions options)
        {
            switch(value)
            {
                case Method.POST:
                writer.WriteStringValue("POST");
                break;
                case Method.GET:
                writer.WriteStringValue("GET");
                break;
                case Method.PUT:
                writer.WriteStringValue("PUT");
                break;
                case Method.PATCH:
                writer.WriteStringValue("PATCH");
                break;
                case Method.DELETE:
                writer.WriteStringValue("DELETE");
                break;
                case Method.NONE:
                    break;
                default:
                throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }
    }
}
