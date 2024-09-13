using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboMdp
{
    internal class LectureFichier
    {
        public  string[] LireFichier(string nomFichier)
        {
            string[] contenuFichier = null;
            try
            {
                contenuFichier = File.ReadAllLines(nomFichier);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la lecture du fichier : " + ex.Message);
            }
            return contenuFichier;
        }
    }
}
