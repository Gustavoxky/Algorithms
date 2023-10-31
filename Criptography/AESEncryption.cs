using System;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt
{
    class AESEncryption
    {
        public static string Encrypt(string plainText, string password)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Gere uma chave de 256 bits a partir da senha
                // Use um algoritmo de hash específico e um número de iterações (por exemplo, SHA256 e 10000 iterações)
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(password, new byte[8], 10000, HashAlgorithmName.SHA256);
                aesAlg.Key = keyDerivation.GetBytes(32); // 32 bytes = 256 bits

                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                byte[] encrypted;

                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }

                    encrypted = msEncrypt.ToArray();
                }

                // Combine o IV com os dados criptografados (necessário para descriptografar)
                byte[] combinedData = new byte[aesAlg.IV.Length + encrypted.Length];
                Array.Copy(aesAlg.IV, combinedData, aesAlg.IV.Length);
                Array.Copy(encrypted, 0, combinedData, aesAlg.IV.Length, encrypted.Length);

                return Convert.ToBase64String(combinedData);
            }
        }

        public static string Decrypt(string cipherText, string password)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Gere uma chave de 256 bits a partir da senha
                // Use um algoritmo de hash específico e um número de iterações (por exemplo, SHA256 e 10000 iterações)
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(password, new byte[8], 10000, HashAlgorithmName.SHA256);
                aesAlg.Key = keyDerivation.GetBytes(32); // 32 bytes = 256 bits

                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                // Separe o IV dos dados criptografados
                byte[] iv = new byte[aesAlg.IV.Length];
                Array.Copy(cipherBytes, iv, aesAlg.IV.Length);

                string plaintext;

                using (var msDecrypt = new System.IO.MemoryStream(cipherBytes, aesAlg.IV.Length, cipherBytes.Length - aesAlg.IV.Length))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, aesAlg.CreateDecryptor(aesAlg.Key, iv), CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

                return plaintext;
            }
        }
    }
}
