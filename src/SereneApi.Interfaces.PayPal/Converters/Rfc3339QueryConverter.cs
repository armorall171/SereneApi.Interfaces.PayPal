using SereneApi.Abstractions.Queries;
using System;

namespace SereneApi.Interfaces.PayPal.Converters
{
    internal class Rfc3339QueryConverter: QueryConverter<DateTime>
    {
        public override string Convert(DateTime value)
        {
            string valueString = value.ToString("yyyy-MM-ddThh:mm:ssZ");

            return valueString;
        }
    }
}
