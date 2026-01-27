
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
        private string nom = "";

        /// <summary>
        /// Prénom de la personne
        /// </summary>
        private string prenom = "";

        /// <summary>
        /// Age de la personne
        /// </summary>
        private int age;

        /// <summary>
        /// Nom de la personne
        /// </summary>
        public string Nom
        {
            get
            {
                return nom;
            }
            private set
            {
                if (value is null)
                {
                    throw new ArgumentException("Le nom est null");
                }
                if (value == "")
                {
                    throw new ArgumentException("Le nom est vide");
                }
                nom = value;
            }
        }

        /// <summary>
        /// Prenom de la personne
        /// </summary>
        public string Prenom
        {
            get
            {
                return prenom;
            }
            private set
            {
                if (value is null)
                {
                    throw new ArgumentException("Le prenom est null");
                }
                if (value == "")
                {
                    throw new ArgumentException("Le prenom est vide");
                }
                prenom = value;
            }
        }

        /// <summary>
        /// Age de la personne
        /// </summary>
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age inférieure a 0");
                }
                age = value;
            }
        }


        /// <summary>
        /// Constructeur de la classe personne
        /// </summary>
        /// <param name="nom">Nom de la personne</param>
        /// <param name="prenom">Prenom de la personne</param>
        /// <param name="age">Age de la personne</param>
        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        /// <summary>
        /// Permet de faire Vieillir la personne de un an.
        /// </summary>
        public void Vieillir()
        {
            Age += 1;
        }

        /// <summary>
        /// Retourne une représentation textuelle de la personne, <br/>
        /// comprenant le prénom, le nom et l'âge.
        /// </summary>
        /// <returns>Une chaîne contenant le prénom, le nom et l'âge de la personne.</returns>
        public override string ToString()
        {
            return $"{Prenom} {Nom}, {Age} ans";
        }
    }
}