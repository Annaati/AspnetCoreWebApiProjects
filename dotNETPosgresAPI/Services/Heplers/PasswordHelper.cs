using System.Security.Cryptography;
using System.Text;

namespace dotNETPosgresAPI.Services.Heplers
{
    public class PasswordHelper
    {

        public static string HashPswd(string password)
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(password);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5"))?.ComputeHash(encodedPassword);
            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();

            return encoded;//returns hashed version of password
        }





    }
}
