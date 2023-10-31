// using System;
// using System.Security.Cryptography;
// using System.Text;

// class SHAHashing
// {
//     public static string ComputeSHA256Hash(string input)
//     {
//         using (SHA256 sha256 = SHA256.Create())
//         {
//             byte[] inputBytes = Encoding.UTF8.GetBytes(input);
//             byte[] hashBytes = sha256.ComputeHash(inputBytes);
//             return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
//         }
//     }

//     public static string ComputeSHA512Hash(string input)
//     {
//         using (SHA512 sha512 = SHA512.Create())
//         {
//             byte[] inputBytes = Encoding.UTF8.GetBytes(input);
//             byte[] hashBytes = sha512.ComputeHash(inputBytes);
//             return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
//         }
//     }
// }
