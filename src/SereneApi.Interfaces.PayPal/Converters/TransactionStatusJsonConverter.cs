using SereneApi.Interfaces.PayPal.API.Enums;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SereneApi.Interfaces.PayPal.Converters
{
    internal class TransactionStatusJsonConverter: JsonConverter<TransactionStatus>
    {
        public override TransactionStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString() switch
            {
                "D" => TransactionStatus.Denied,
                "F" => TransactionStatus.PartialRefund,
                "P" => TransactionStatus.Pending,
                "S" => TransactionStatus.Successful,
                "V" => TransactionStatus.Refunded,
                _ => throw new ArgumentOutOfRangeException("")
            };
        }

        public override void Write(Utf8JsonWriter writer, TransactionStatus value, JsonSerializerOptions options)
        {
            switch(value)
            {
                case TransactionStatus.Denied:
                writer.WriteStringValue("D");
                break;
                case TransactionStatus.PartialRefund:
                writer.WriteStringValue("F");
                break;
                case TransactionStatus.Pending:
                writer.WriteStringValue("P");
                break;
                case TransactionStatus.Successful:
                writer.WriteStringValue("S");
                break;
                case TransactionStatus.Refunded:
                writer.WriteStringValue("V");
                break;
                default:
                throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }
    }
}
