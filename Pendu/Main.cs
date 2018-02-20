using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            
            //TODO
            Console.WriteLine("HelloWorld !");
        }

        /// <summary>
        /// Tire aléatoirement un mo et le revoie. Le mot sera toujours en majuscule
        /// </summary>
        /// <returns>string</returns>
        public static string getRandomWord()
        {
            List<string> dictionnaire = new List<string>();
            dictionnaire.Add("AVOCAT");
            dictionnaire.Add("BONJOUR");
            dictionnaire.Add("COMPRENDRE");
            dictionnaire.Add("DROIT");
            dictionnaire.Add("ELEPHANT");
            dictionnaire.Add("FENETRE");
            dictionnaire.Add("GUITARE");
            dictionnaire.Add("HELICE");
            dictionnaire.Add("ITALIE");
            dictionnaire.Add("JOURNAL");
            dictionnaire.Add("KOALA");
            dictionnaire.Add("LONGUEUR");
            dictionnaire.Add("MATIN");
            dictionnaire.Add("NOCTAMBULE");
            dictionnaire.Add("OPERATEUR");
            dictionnaire.Add("QUALITE");
            dictionnaire.Add("ROBINET");
            dictionnaire.Add("SAUVETAGE");
            dictionnaire.Add("TRAMPOLINE");
            dictionnaire.Add("UNIVERS");
            dictionnaire.Add("VOITURE");
            dictionnaire.Add("WAGON");
            dictionnaire.Add("XYLOPHONE");
            dictionnaire.Add("YOGA");
            dictionnaire.Add("ZERO");
            //TODO
            return "";
        }

        /// <summary>
        /// Indique si une lettre est présente dans le mot ou non
        /// </summary>
        /// <param name="letter">Lettre testée</param>
        /// <param name="motADeviner">Mot testé</param>
        /// <returns>Un booléen</returns>
        public static bool isInWord(char letter, string motADeviner)
        {
            //TODO
            return false;
        }

        /// <summary>
        /// Initialise le mot à completer à partir du mot à deviner
        /// </summary>
        /// <param name="motADeviner">Mot à deviner</param>
        /// <returns></returns>
        public static string initMotACompleter(string motADeviner)
        {
            //TODO
            string motACompleter = "";
            return motACompleter;
        }

        /// <summary>
        /// Place la lettre donné par l'utilisateur dans le mot à complèter
        /// </summary>
        /// <param name="lettre">lettre de l'utilisateur</param>
        /// <param name="motACompleter">mot à compléter</param>
        /// <param name="motADeviner">mot à deviner</param>
        /// <returns></returns>
        public static string completMot(char lettre, string motACompleter, string motADeviner)
        {
            //TODO
            string tmp = "";
            return tmp;
        }

        /// <summary>
        /// Demande à l'utilisateur une lettre et la retourne
        /// </summary>
        /// <param name="lettreTrouvee">tableau des lettres déjà trouvée par l'utilisateur</param>
        /// <returns>la lettre donnée par l'utilisateur</returns>
        public static char getLetter(List<char> lettreTrouvee)
        {
            // TODO
            char lettre = 'a';
            return lettre;
        }

        /// <summary>
        /// Coeur principal du jeu
        /// </summary>
        /// <returns></returns>
        public static bool jeu(string motADeviner)
        {
            int chance = 7;
            //TODO
            string motACompleter ="";
            char lettre;
            List<char> lettreTrouvee = new List<char>();
            
            while (motACompleter != motADeviner && chance > 0)
            {
                
                Console.WriteLine("Le mot à compléter est "+motACompleter);
                
                // TODO
            }

            // TODO
            return false;
        }
        
    }
}