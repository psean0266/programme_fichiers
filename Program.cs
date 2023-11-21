using System;
using System.Collections.Generic;
using System.IO;

namespace programme_fichiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Pour plcer documents
            //   var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);  // pour placer dans bureau
            var path = "out";

            if(!Directory.Exists(path)) {

                Directory.CreateDirectory(path);
            }

            

            string filename = "nomFichier.txt";
            string filename2 = "nomFichier2.txt";

            string pathAndFile = Path.Combine(path, filename);
            string pathAndFile2 = Path.Combine(path, filename2);





            if (File.Exists(pathAndFile))
            {
                Console.WriteLine("Le fichier existe déjà, on va écraser son contenu");
            }

            else
            {
                Console.WriteLine("Le fichier n'existe pas, On va le créer");
            }

            Console.WriteLine("FICHIER: "+pathAndFile);
            //File.WriteAllText("nomFichier.txt", "Voici le contenue que j'ai écrit dans le fichier texte ");
            //File.AppendAllText(filename, " Je rajoute ce texte");

            var noms = new List<string>
            {
                "Jean",
                "Paul",
                "Martin"
            };

            File.WriteAllLines(pathAndFile, noms);


            try
            {
                //     string resultat = File.ReadAllText("nomFichier.txt");

                var lignes = File.ReadAllLines(pathAndFile);

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


           // File.Copy(pathAndFile, pathAndFile2);  
          // File.Delete(pathAndFile2);    
           File.Move(pathAndFile2, pathAndFile2); // renomer le fichier

        }
    }
}
