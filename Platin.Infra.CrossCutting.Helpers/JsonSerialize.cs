using Newtonsoft.Json.Serialization;
using System.Globalization;
using System.Net.Http.Formatting;

namespace Platin.Infra.CrossCutting.Helpers
{
    public class JsonSerialize
    {
        public void SerializarJson(JsonMediaTypeFormatter formatter)
        {
            var json = formatter.SerializerSettings;

            json.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
            json.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
            json.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            json.Formatting = Newtonsoft.Json.Formatting.Indented;
            json.ContractResolver = new CamelCasePropertyNamesContractResolver();
            json.Culture = new CultureInfo("it-IT");
        }

    }
}
