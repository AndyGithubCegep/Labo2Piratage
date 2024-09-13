using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LaboMdp
{
    internal class EcritureFichier
    {
        public  void EcrireFichier(string nomFichier, string[] contenu)
        {
            try
            {
                Crypter crypter = new Crypter();
                string[] contenuCrypte = new string[contenu.Length];
                for (int i = 0; i < contenu.Length; i++)
                {
                    contenuCrypte[i] = crypter.CrypterContenu(contenu[i]);
                }
                System.IO.File.WriteAllLines(nomFichier, contenuCrypte);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'écriture du fichier : " + ex.Message);
            }
        }
    }
}
