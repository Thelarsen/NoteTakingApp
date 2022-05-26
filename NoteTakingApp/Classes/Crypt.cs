using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp.Classes
{
    internal class Crypt
    {
        // Password is encrypted using SHA256 encryption and encrypted password is returned.
        public static string hashPassword(string password) // Password is sent in as parameter.
        {
            // Convert password string input to bytes.
            byte[] passwordData = Encoding.UTF8.GetBytes(password);
            byte[] result;
            SHA256 shaM = new SHA256Managed();
            // Password is encrypted.
            result = shaM.ComputeHash(passwordData);
            // Convert hashed password to base64 string.
            String base64result = Convert.ToBase64String(result);
            Console.WriteLine(base64result);
            // Return encrypted password.
            return base64result;            
        }
    }
}
