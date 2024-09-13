using LaboMdp;

class Program
{
    static void Main()
    {
        // Demander à l'utilisateur de saisir le nom du fichier
        Console.Write("Veuillez entrer le chemin du fichier : ");
        string inputFile = Console.ReadLine();
        // le nom du fichier de sortie
        Console.Write("Veuillez entrer le chemin du fichier : ");
        string outputFile = Console.ReadLine();
        // Lire le contenu du fichier
        LectureFichier lecteur = new LectureFichier();
        string[] contenuFichier = lecteur.LireFichier(inputFile);
        // Crypter le contenu du fichier
        EcritureFichier ecriture = new EcritureFichier();
        ecriture.EcrireFichier(outputFile, contenuFichier);
    }
}
           