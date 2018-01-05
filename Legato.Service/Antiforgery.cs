using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Legato.Service
{
    public static class Antiforgery
    {
        public static bool ValidateToken(string tokenName, string tokenString)
        {
            try
            {
                var root = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($@"{AppDomain.CurrentDomain.BaseDirectory}/settings.json"));
                return root[tokenName] == tokenString;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}