using System.Text;
using System.Security.Cryptography;


namespace Legato.DAL.Util
{
    public static class Hashing
    {
        public static string HashData(string data)
        {
            return Encoding.UTF8.GetString(SHA1.Create().ComputeHash(Encoding.Unicode.GetBytes(data)));
        }
    }
}
