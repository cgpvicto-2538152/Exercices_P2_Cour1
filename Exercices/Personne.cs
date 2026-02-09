namespace Exercices
{
    /// <include file='../Doc.xml' path='Doc/Personne.cs/Class/Personne'/>
    public class Personne
    {
        private string nom = "";
        private string prenom = "";
        private int age;

        /// <include file='../Doc.xml' path='Doc/Personne.cs/Methodes/Nom'/>
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
                    throw new ArgumentNullException(nameof(Nom), "Le nom est null");
                }
                if (value == "")
                {
                    throw new ArgumentException("Le nom est vide", nameof(Nom));
                }
                nom = value;
            }
        }

        /// <include file='../Doc.xml' path='Doc/Personne.cs/Methodes/Prenom'/>
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
                    throw new ArgumentNullException(nameof(Prenom), "Le prenom est null");
                }
                if (value == "")
                {
                    throw new ArgumentException("Le prenom est vide", nameof(Prenom));
                }
                prenom = value;
            }
        }

        /// <include file='../Doc.xml' path='Doc/Personne.cs/Methodes/Age'/>
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
                    throw new ArgumentOutOfRangeException(nameof(Age), "L'age ne peut pas etre inferieur a 0");
                }
                age = value;
            }
        }


        /// <include file='../Doc.xml' path='Doc/Personne.cs/Methodes/Constructeur'/>
        public Personne(string nom, string prenom, int age)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
        }

        /// <include file='../Doc.xml' path='Doc/Personne.cs/Methodes/Vieillir'/>
        public void Vieillir()
        {
            Age += 1;
        }

        /// <include file='../Doc.xml' path='Doc/Personne.cs/Methodes/ToString'/>
        public override string ToString()
        {
            return $"{Prenom} {Nom}, {Age} ans";
        }
    }
}