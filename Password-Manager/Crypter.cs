using System;
using System.Security.Cryptography;
using System.Text;

namespace Password_Manager
{
    class Crypter
    {
        private static RSACryptoServiceProvider s_rsa;

        public static void SetKey(byte[] keyBytes)
        {
            s_rsa = new RSACryptoServiceProvider();

            string key = Encoding.UTF8.GetString(keyBytes);
            s_rsa.FromXmlString(key);
        }

        public static byte[] GetKey()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            return Encoding.UTF8.GetBytes(rsa.ToXmlString(true));
        }

        public static string Decrypt(string text)
        {
            byte[] decrContent = s_rsa.Decrypt(Convert.FromBase64String(text), true);

            return ToString(decrContent);
        }

        private static string ToString(byte[] decrContent)
        {
            return Encoding.UTF8.GetString(decrContent);
        }

        private static byte[] ToByte(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }

        public static string Encrypt(string text)
        {
            byte[] encContent = s_rsa.Encrypt(ToByte(text), true);

            return Convert.ToBase64String(encContent);
        }

        public static string GetPassword()
        {
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
            byte[] arr = new byte[10];
            rngCsp.GetBytes(arr);

            return Convert.ToBase64String(arr);
        }
    }
}
