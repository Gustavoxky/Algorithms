using System;
using System.Security.Cryptography;
using System.Text;

namespace RSAEncrypt;

class RSAEncryption
{
    public static string Encrypt(string plainText, RSAParameters publicKey)
    {
        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
        {
            rsa.ImportParameters(publicKey);

            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedBytes = rsa.Encrypt(plainBytes, true);

            return Convert.ToBase64String(encryptedBytes);
        }
    }

    public static string Decrypt(string cipherText, RSAParameters privateKey)
    {
        using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
        {
            rsa.ImportParameters(privateKey);

            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] decryptedBytes = rsa.Decrypt(cipherBytes, true);

            return Encoding.UTF8.GetString(decryptedBytes);
        }
    }
}
