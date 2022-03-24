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
        public static string hashPassword(string password)
        {
            byte[] passwordData = Encoding.UTF8.GetBytes(password);
            byte[] result;
            SHA256 shaM = new SHA256Managed();
            result = shaM.ComputeHash(passwordData);
            String base64result = Convert.ToBase64String(result);
            Console.WriteLine(base64result);
            return base64result;            
        }
    }
}
