using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LaboMdp
{
    internal class Crypter
    {
        public string CrypterContenu(string contenu)
        {
            try
            {
                MD5 myMD5 = MD5.Create();
                byte[] hashValue = myMD5.ComputeHash(Encoding.UTF8.GetBytes(contenu));
                return BitConverter.ToString(hashValue).Replace("-","");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du cryptage du contenu : " + ex.Message);
                return null;
            }
        }
    }
}
