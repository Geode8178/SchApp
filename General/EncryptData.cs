using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SchApp.General
{
    public class EncryptData
    {
        public static string DataSecure(string SecureString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] mashup = Encoding.UTF8.GetBytes(SecureString);
            return Encoding.UTF8.GetString(md5.ComputeHash(mashup));

        }
        
    }
    
}
