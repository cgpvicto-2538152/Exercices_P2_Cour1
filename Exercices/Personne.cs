
using System.Security.Cryptography.X509Certificates;

namespace Exercices
{
    /// <summary>
    /// Classe qui définie l'instance d'une personne
    /// </summary>
    public class Personne
    {
        /// <summary>
        /// Nome de la personne
        /// </summary>
        public string Nom;

        /// <summary>
        /// Prénom de la personne
        /// </summary>
        public string Prenom;

        /// <summary>
        /// Age de la personne
        /// </summary>
        public int Age;

        /// <summary>
        /// Constructeur de la classe personne
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="age"></param>
        public Personne(string nom, string prenom, int age)
        {
            Nom = !string.IsNullOrWhiteSpace(nom) ? nom : "John";
            Prenom = !string.IsNullOrWhiteSpace(prenom) ? prenom : "Doe";
            Age = age >= 0 ? age : 1;
        }

        /// <summary>
        /// Permet de faire Vieillir la personne de un an.
        /// </summary>
        public void Vieillir()
        {
            Age += 1;
        }

        public override string ToString()
        {
            return $"{Prenom} {Nom} , {Age}";
        }

    }
}