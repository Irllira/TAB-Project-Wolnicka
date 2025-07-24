using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace WindowsFormsApp1
{
    class Hasher
    {
        public string CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);

            return Convert.ToBase64String(buff);
        }
        public string HashPassword(string pass, string salt)
        {
            // string hashed = Bcrypt.Net;
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(pass + salt);

            System.Security.Cryptography.SHA256Managed sHA256 = new System.Security.Cryptography.SHA256Managed();

            byte[] hash = sHA256.ComputeHash(bytes);

            return Convert.ToBase64String(hash);

        }
    }
}
