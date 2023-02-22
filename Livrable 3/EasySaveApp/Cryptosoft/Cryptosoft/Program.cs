using System;
using System.IO;
using System.Security.Cryptography;

namespace CryptageFichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Récupérer le chemin du dossier source et du dossier de destination
            Console.WriteLine("Entrez le chemin du dossier source : ");
            string dossierSource = Console.ReadLine();

            Console.WriteLine("Entrez le chemin du dossier de destination : ");
            string dossierDestination = Console.ReadLine();

            // Lecture des extensions prioritaires
            Console.WriteLine("Entrez les extensions prioritaires (séparées par une virgule) :");
            string extensionsPrioritaires = Console.ReadLine();
            string[] extensionsPrioritairesListe = extensionsPrioritaires.Split(',');

            // Lecture des extensions à crypter
            Console.WriteLine("Entrez les extensions à crypter (séparées par une virgule) :");
            string extensionsACrypter = Console.ReadLine();
            string[] extensionsACrypterListe = extensionsACrypter.Split(',');

            // Lecture des fichiers à crypter
            string[] fichiersSource = Directory.GetFiles(dossierSource);

            // Cryptage des fichiers prioritaires
            foreach (string fichier in fichiersSource)
            {
                string extension = Path.GetExtension(fichier);
                if (Array.Exists(extensionsPrioritairesListe, element => element.Trim() == extension) &&
                    !File.Exists(Path.Combine(dossierDestination, Path.GetFileName(fichier))))
                {
                    CrypterFichier(fichier, Path.Combine(dossierDestination, Path.GetFileName(fichier)));
                }
            }

            // Cryptage des autres fichiers
            foreach (string fichier in fichiersSource)
            {
                string extension = Path.GetExtension(fichier);
                if (Array.Exists(extensionsACrypterListe, element => element.Trim() == extension) &&
                    !File.Exists(Path.Combine(dossierDestination, Path.GetFileName(fichier))))
                {
                    CrypterFichier(fichier, Path.Combine(dossierDestination, Path.GetFileName(fichier)));
                }
            }
        }

        static void CrypterFichier(string fichierSource, string fichierDestination)
        {
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.GenerateIV();
                aes.GenerateKey();
                byte[] iv = aes.IV;
                byte[] cle = aes.Key;

                using (FileStream fsSource = new FileStream(fichierSource, FileMode.Open))
                {
                    using (FileStream fsDestination = new FileStream(fichierDestination, FileMode.CreateNew))
                    {
                        fsDestination.Write(iv, 0, iv.Length);
                        fsDestination.Write(cle, 0, cle.Length);

                        using (CryptoStream cs = new CryptoStream(fsDestination, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            byte[] buffer = new byte[1024];
                            int read;

                            while ((read = fsSource.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cs.Write(buffer, 0, read);
                            }
                        }
                    }
                }
            }
        }
    }
}
