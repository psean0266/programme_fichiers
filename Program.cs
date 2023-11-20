using System;
using System.Collections.Generic;
using System.IO;

namespace programme_fichiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "nomFichier.txt";
            //File.WriteAllText("nomFichier.txt", "Voici le contenue que j'ai écrit dans le fichier texte ");
            //File.AppendAllText(filename, " Je rajoute ce texte");

            var noms = new List<string>
            {
                "Jean",
                "Paul",
                "Martin"
            };

            File.WriteAllLines(filename, noms);


            try
            {
                //int a = 1;
                //a = a / 0;
                //     string resultat = File.ReadAllText("nomFichier.txt");

                var lignes = File.ReadAllLines("nomFichier.txt");

                foreach (var ligne in lignes) {

                    Console.WriteLine(ligne);
                }

                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("ERREUR:Ce fichier n'existe pas (" + ex.Message + ")");
            }

            catch
            {
                Console.WriteLine("UNE ERREUR inconnu est arrivé");
            }

        }
    }
}
