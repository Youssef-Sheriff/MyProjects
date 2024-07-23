using System.Text;

namespace PasswordManager
{
    public class Encryption
    {
        private static readonly string originalChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static readonly string altChars = "dNvA9Ll3Oty1kVoaHR8K6UJ7bGZWhF2siTDpnfxM0rXjQcI4zS5gBmPCwEeuYq";
        public static string Encrypt(string password)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ch in password)
            {
                int charIdx = originalChars.IndexOf(ch);
                sb.Append(altChars[charIdx]);
            }

            return sb.ToString();
        }

        public static string Decrypt(string password)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var ch in password)
            {
                int charIdx = altChars.IndexOf(ch);
                sb.Append(originalChars[charIdx]);
            }

            return sb.ToString();
        }
    }
}