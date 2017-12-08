using System;
using Newtonsoft.Json;


namespace Legato.Service
{
    public static class Serialization
    {
        public static TDeserialized Deserialize<TDeserialized>(string value)
            where TDeserialized: class
        {
            try
            {
                return JsonConvert.DeserializeObject<TDeserialized>(value, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Include
                });
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include
            });
        }
    }
}