using System;
using System.Text;
using System.Security.Cryptography;


namespace Legato.DAL.Util
{
    public static class Hashing
    {
        public static string HashData(string data)
        {
            using (var sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(data));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
