

using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Exercices
{

    /// <summary>
    /// Classe qui regroupe les méthodes des exercices à faire.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programme de démarage
        /// </summary>
        /// <param name="args">Argument de démarage</param>
        public static void Main(string[] args)
        {
            // Efface toute la consoe et le buffer (le scroll)
            Console.WriteLine("\u001b[3J\u001b[H\u001b[2J");

            #region Liste
            // Liste de prenom generer par IA
            string[] lstPrenom =
            {
                "Alice",
                "Bob",
                "Charlie",
                "Diana",
                "Ethan",
                "Fiona",
                "George",
                "Hannah",
                "Ian",
                "Julia",
                "Kevin",
                "Laura",
                "Michael",
                "Nina",
                "Oliver",
                "Paula",
                "Quentin",
                "Rachel",
                "Samuel",
                "Tina",
                "Ulysses",
                "Victoria",
                "William",
                "Xavier",
                "Yvonne",
                "Zachary"
            };
            // Liste de nom generer par IA
            string[] lstNom =
            {
                "Anderson",
                "Brown",
                "Clark",
                "Davis",
                "Evans",
                "Franklin",
                "Garcia",
                "Harris",
                "Iverson",
                "Johnson",
                "King",
                "Lewis",
                "Miller",
                "Nelson",
                "Owens",
                "Parker",
                "Quinn",
                "Roberts",
                "Smith",
                "Taylor",
                "Upton",
                "Vasquez",
                "Williams",
                "Xanders",
                "Young",
                "Zimmerman"
            };

            #endregion


            #region Test

            Espacer(1);
            Exercice1();

            Espacer(2);
            Exercice2(5, 98);

            Espacer(3);
            int nb_ex3 = Exercice3(5, 98);
            Console.WriteLine(nb_ex3);

            Espacer(4);
            double nb_ex4 = Exercice4();
            Console.WriteLine(nb_ex4);

            Espacer(5);
            int nb_ex5 = Exercice5();
            Console.WriteLine(nb_ex5);

            Espacer(6);
            int nb_ex6 = Exercice6();
            Console.WriteLine(nb_ex6);

            Espacer(7);
            int nb_ex7 = Exercice7(8, -2);
            Console.WriteLine(nb_ex7);

            Espacer(8);
            int[] tab_ex8 = Exercice8(6);
            Console.WriteLine(tab_ex8.Length);

            Espacer(9);
            int[] tab_ex9 = Exercice9(8, 2, 9);
            for (int i_ex9 = 0; i_ex9 < tab_ex9.Length; i_ex9++)
            { Console.Write($"{tab_ex9[i_ex9]}  "); }

            Espacer(10);
            int[] tab_ex10 = Exercice10(15, 18, 30);
            for (int i_ex10 = 0; i_ex10 < tab_ex10.Length; i_ex10++)
            { Console.Write($"{tab_ex10[i_ex10]}  "); }

            Espacer(11);
            int[] tab_ex11 = Exercice11(6, 7, 2);
            for (int i_ex11 = 0; i_ex11 < tab_ex11.Length; i_ex11++)
            { Console.Write($"{tab_ex11[i_ex11]}  "); }


            Espacer(12);
            int[] tab_ex12 = Exercice12(-1, -5, 2);
            for (int i_ex12 = 0; i_ex12 < tab_ex12.Length; i_ex12++)
            { Console.Write($"{tab_ex12[i_ex12]}  "); }

            Espacer(13);
            int[] tab_ex13 = Exercice9(8, 2, 9);
            int nb_ex13 = Exercice13(tab_ex13);
            Console.WriteLine(nb_ex13);

            Espacer(14);
            int[] tab_ex14 = Exercice9(8, 2, 9);
            int nb_ex14 = Exercice14(tab_ex14);
            Console.WriteLine(nb_ex14);

            Espacer(15);
            int[] tab_ex15 = Exercice9(8, 2, 9);
            int nb_ex15 = Exercice15(tab_ex15);
            Console.WriteLine(nb_ex15);

            Espacer(16);
            int[] tab_ex16 = Exercice9(8, 2, 9);
            int nb_ex16 = Exercice16(tab_ex16);
            Console.WriteLine(nb_ex16);

            Espacer(17);
            Exercice17();

            Espacer(18);
            Exercice18(5);

            Espacer(19);
            Exercice19(-6);

            Espacer(20);
            Exercice20(-1, 7);

            Espacer(21);
            Exercice21(4, 4, 'S');

            Espacer(22);
            Exercice22(4, 4, 4, '4');

            Espacer(23);
            Exercice23(-1);

            Espacer(24);
            Exercice24(4);

            Espacer(25);
            Exercice25(7);

            Espacer(26);
            Exercice26(7);

            Espacer(27);
            string forme = Exercice27(6);
            Console.WriteLine(forme);

            Espacer(28);
            int[] tab_ex28 = Exercice9(0, 1, 10);
            double nb_ex28 = Exercice28(tab_ex28);
            Console.WriteLine(nb_ex28);

            Espacer(29);
            int[] tab_ex29 = Exercice9(7, 1, 10);
            double nb_ex29 = Exercice29(tab_ex29);
            Console.WriteLine(nb_ex29);

            Espacer(30);
            Personne pers_ex30 = new("Alexis", "Bergeois", 19);
            Console.WriteLine($"{pers_ex30.Nom} {pers_ex30.Prenom} a {pers_ex30.Age} ans");
            pers_ex30.Vieillir();
            Console.WriteLine($"{pers_ex30.Nom} {pers_ex30.Prenom} a {pers_ex30.Age} ans");

            Espacer(31);
            Personne[] pers_ex31 = Exercice31(10, 10, 100, lstPrenom, lstNom);
            foreach (Personne personne in pers_ex31)
            { Console.WriteLine(personne.ToString()); }

            Espacer(32);
            Personne[] tabPersEx32 = Exercice31(10, 1, 25, lstPrenom, lstNom);
            double nbEx32 = Exercice32(tabPersEx32);
            Console.WriteLine(nbEx32);

            Espacer(33);
            Personne[] tabPersEx33 = Exercice31(10, 1, 56, lstPrenom, lstNom);
            Personne persEx33 = Exercice33(tabPersEx33);
            Console.WriteLine(persEx33);

            Espacer(34);
            int[] tab_ex34 = Exercice9(7, 1, 9);
            foreach (int nb in tab_ex34)
            { Console.Write($"{nb}  "); }
            Exercice34(tab_ex34, 0, 1);
            Console.WriteLine("\n0--1--2--3--4--5--6");
            foreach (int nb in tab_ex34)
            { Console.Write($"{nb}  "); }

            Espacer(35);
            int[] tab_ex35 = [1, 2, 3, 4, 5, 6, 7];
            foreach (int nb in tab_ex35)
            { Console.Write($"{nb}  "); }
            Exercice35(tab_ex35);
            Console.WriteLine("\n0--1--2--3--4--5--6");
            foreach (int nb in tab_ex35)
            { Console.Write($"{nb}  "); }

            Espacer(36);
            int[] tab_ex36 = [1, 2, 3, 4, 5, 6, 7];
            foreach (int nb in tab_ex36)
            { Console.Write($"{nb}  "); }
            Exercice36(tab_ex36);
            Console.WriteLine("\n0--1--2--3--4--5--6");
            foreach (int nb in tab_ex36)
            { Console.Write($"{nb}  "); }

            Espacer(37);
            char[] chars = { 'S', 'i', 'm', 'o', 'n' };
            int nb_ex37 = Exercice37(chars, 'o');
            Console.WriteLine(nb_ex37);

            Espacer(38);
            int[] tabEx38 = [1, 2, 3, 4, 5, 4, 7];
            foreach (int nb in tabEx38)
            { Console.Write($"{nb}  "); }
            int nbEx38 = Exercice38(tabEx38);
            Console.WriteLine("\n0--1--2--3--4--5--6");
            Console.WriteLine(nbEx38);

            Espacer(39);
            int[] tabEx39a = [1, 3, 3, 4, 5, 4, 7];
            foreach (int nb in tabEx39a)
            { Console.Write($"{nb}  "); }
            int[] tabEx39b = Exercice39(tabEx39a);
            Console.WriteLine("\n0--1--2--3--4--5--6");
            foreach (int nb in tabEx39b)
            { Console.Write($"{nb}  "); }

            #endregion

            Espacer(40);
            int[] tabEx40a = [1, 2, 3];
            int[] tabEx40b = [4, 5, 6];
            int[] tabEx40c = Exercice40(tabEx40a, tabEx40b);
            Console.Write($"Tab 1 : ");
            foreach (int nb in tabEx40a)
            { Console.Write($"{nb}  "); }
            Console.Write("\nTab 2 : ");
            foreach (int nb in tabEx40b)
            { Console.Write($"{nb}  "); }
            Console.WriteLine("\nTab fusionner : ");
            foreach (int nb in tabEx40c)
            { Console.Write($"{nb}  "); }






        }


        /// <summary>
        /// Affiche un espacement entre deux exercices et affiche le numero de l'exercices
        /// </summary>
        /// <param name="numExe"></param>
        public static void Espacer(int numExe)
        {
            Console.WriteLine("\n- - - - - - - - - - - -");
            Console.WriteLine($"Exercice {numExe}\n");
        }


        #region Fait

        /// <summary>
        /// Affiche un message à la console.
        /// </summary>
        public static void Exercice1()
        {
            Console.WriteLine("Allô p2");
        }

        /// <summary>
        /// Affiche deux nombre entier à la console.
        /// </summary>
        /// <param name="nb1">Premier nombre entier</param>
        /// <param name="nb2">Deuxième nombre entier</param>
        public static void Exercice2(int nb1, int nb2)
        {
            Console.WriteLine($"Premier entier : {nb1}");
            Console.WriteLine($"Deuxième entier : {nb2}");
        }

        /// <summary>
        /// Additione deux nombres entiers ensemble et retourne le résultat.
        /// </summary>
        /// <param name="nb1">Premier nombre entier</param>
        /// <param name="nb2">Deuxième nombre entier</param>
        /// <returns>Nombre entier résulatant de l'addition des deux nombres.</returns>
        public static int Exercice3(int nb1, int nb2)
        {
            return nb1 + nb2;
        }

        /// <summary>
        /// Demande un nombre a l'utilisateur et le retourne en double.
        /// </summary>
        /// <returns>Le nombre rentrer par l'utilisateur</returns>
        public static double Exercice4()
        {
            Console.Write("Entrer un nombre : ");
            if (double.TryParse(Console.ReadLine(), out double nb))
            {
                return nb;
            }
            throw new Exception("Ce n'est pas un nombre");
        }

        /// <summary>
        /// Demande a l'utilisateur d'entrer un nombre et le valide selon des conditions.
        /// </summary>
        /// <returns>
        ///     -1 si ce n'est pas un nombre, si il est vide, si il est inférieure a 0 <br/>
        ///     Le nombre si il est valide et supérieure a 0.
        /// </returns>
        public static int Exercice5()
        {
            Console.Write("Entrer un nombre : ");
            if (int.TryParse(Console.ReadLine(), out int nb) && nb > 0)
            {
                return nb;
            }
            else
            {
                Debug.WriteLine("Ce n'est pas un nombre", "Exercice 5");
                return -1;
            }
        }

        /// <summary>
        /// Demande un nombre a l'utilisateur tant qu'il n'est pas suprérieur a 10.
        /// </summary>
        /// <returns>Le nombre quand il sera supérieur a 10</returns>
        public static int Exercice6()
        {
            bool valide = false;
            int nb = -1;
            while (!valide)
            {
                Console.Write("Entrer un nombre supérieur a 10 : ");
                if (int.TryParse(Console.ReadLine(), out nb) && nb > 10)
                {
                    valide = true;
                }
                else
                {
                    Debug.WriteLine("Ce n'est pas un nombre ou inférieure a 10", "Exercice 6");
                }
            }
            return nb;
        }

        /// <summary>
        /// Effectue la division de deux nombres et le modifie selon des contraintes
        /// </summary>
        /// <param name="nb1">Le premier nombre</param>
        /// <param name="nb2">Le deuxième nombre</param>
        /// <returns>
        ///     O si le nb2 est 0 <br/>
        ///     Le nombre de en sa valeur absolue (positive)
        /// </returns>
        public static int Exercice7(int nb1, int nb2)
        {
            if (nb2 == 0)
            {
                Debug.WriteLine("Division par 0", "Exercice 7");
                return 0;
            }
            else
            {
                int res = nb1 / nb2;
                return Math.Abs(res);
            }
        }

        /// <summary>
        /// Créer un tableau de la longueur rentrer en paramètre.
        /// </summary>
        /// <param name="longueur">La longueur voulu pour le tableau</param>
        /// <returns>L'instance du nouveau tableau</returns>
        public static int[] Exercice8(int longueur)
        {
            if (longueur < 0)
            {
                throw new ArgumentException("La longueur doit etre positive");
            }
            return new int[longueur];
        }

        /// <summary>
        /// Initialise un tableau d'une longueur donnée et le remplie aléatoirement avec un minimum et maximum entier donnée.
        /// </summary>
        /// <param name="longueur">La longueur du tableau</param>
        /// <param name="min">L'entier minimum (inclu) </param>
        /// <param name="max">L'entier maximum (exclu)</param>
        /// <returns>Retourne un tableau remplie de valeur aléatoire</returns>
        public static int[] Exercice9(int longueur, int min, int max)
        {
            if (longueur < 0)
            {
                throw new ArgumentException("La longueur doit etre positive");
            }
            Random rnd = new Random();
            int[] tabRnd = new int[longueur];
            for (int i = 0; i < tabRnd.Length; i++)
            {
                tabRnd[i] = rnd.Next(min, max);
            }
            return tabRnd;
        }

        /// <summary>
        /// Initialise un tableau d'une longueur donnée et le remplie aléatoirement avec un minimum et maximum entier donnée.
        /// </summary>
        /// <param name="longueur">La longueur du tableau</param>
        /// <param name="min">L'entier minimum (inclu)</param>
        /// <param name="max">L'entier maximum (inclu)</param>
        /// <returns>Retourne un tableau remplie de valeur aléatoire</returns>
        public static int[] Exercice10(int longueur, int min, int max)
        {
            if (longueur < 0)
            {
                throw new ArgumentException("La longueur doit etre positive");
            }
            Random rnd = new Random();
            int[] tabRnd = new int[longueur];
            for (int i = 0; i < tabRnd.Length; i++)
            {
                tabRnd[i] = rnd.Next(min, max + 1);
            }
            return tabRnd;
        }

        /// <summary>
        /// Initialise un tableau d'une longueur donnée et le remplie aléatoirement avec un minimum et maximum entier donnée.
        /// </summary>
        /// <param name="longueur">La longueur du tableau</param>
        /// <param name="min">L'entier minimum (inclu)</param>
        /// <param name="max">L'entier maximum (inclu)</param>
        /// <returns>Retourne un tableau remplie de valeur aléatoire</returns>
        public static int[] Exercice11(int longueur, int min, int max)
        {
            if (longueur < 0)
            {
                throw new ArgumentException("La longueur doit etre positive");
            }

            Random rnd = new Random();
            int[] tabRnd = new int[longueur];

            if (min > max)
            {
                // int temp = min;
                // min = max;
                // min = temp;
                // - - - - - - - -
                // Utiliser le tuple pour échanger des valeurs (IDE0180)
                (max, min) = (min, max);
            }

            for (int i = 0; i < tabRnd.Length; i++)
            {
                tabRnd[i] = rnd.Next(min, max + 1);
            }
            return tabRnd;
        }

        /// <summary>
        /// Initialise un tableau d'une longueur donnée et le remplie aléatoirement avec un minimum et maximum entier donnée.
        /// </summary>
        /// <param name="longueur">La longueur du tableau</param>
        /// <param name="min">L'entier minimum (inclu)</param>
        /// <param name="max">L'entier maximum (inclu)</param>
        /// <returns>Retourne un tableau remplie de valeur aléatoire</returns>
        public static int[] Exercice12(int longueur, int min, int max)
        {

            if (longueur < 0)
            {
                Debug.WriteLine("La longueur doit etre positive", "Exercice 12");
                return [];
            }

            Random rnd = new Random();

            int[] tabRnd = new int[longueur];

            if (min > max)
            {
                // int temp = min;
                // min = max;
                // min = temp;
                // - - - - - - - -
                // Utiliser le tuple pour échanger des valeurs (IDE0180)
                (max, min) = (min, max);
            }

            for (int i = 0; i < tabRnd.Length; i++)
            {
                tabRnd[i] = rnd.Next(min, max + 1);
            }
            return tabRnd;
        }

        /// <summary>
        /// Fait la somme de tout les nombres d'un tableau de nombres.
        /// </summary>
        /// <param name="tab">Tableau de nombre entiers</param>
        /// <returns>Somme des nombres entier</returns>
        public static int Exercice13(int[] tab)
        {
            int total = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                total += tab[i];
            }
            return total;
        }

        /// <summary>
        /// Fait la somme de tout les nombres d'un tableau de nombres.
        /// </summary>
        /// <param name="tab">Tableau de nombre entiers</param>
        /// <returns>Somme des nombres entier</returns>
        public static int Exercice14(int[] tab)
        {
            int total = 0;
            foreach (int num in tab)
            {
                total += num;
            }
            return total;
        }

        /// <summary>
        /// Fait la somme de tout les nombres d'un tableau de nombres.
        /// </summary>
        /// <param name="tab">Tableau de nombre entiers</param>
        /// <returns>Somme des nombres entier</returns>
        public static int Exercice15(int[] tab)
        {
            int total = 0;
            int index = 0;
            while (index < tab.Length)
            {
                total += tab[index];
                index++;
            }
            return total;
        }

        /// <summary>
        /// Fait la somme de tout les nombres d'un tableau de nombres.
        /// </summary>
        /// <param name="tab">Tableau de nombre entiers</param>
        /// <returns>Somme des nombres entier</returns>
        public static int Exercice16(int[] tab)
        {
            if (tab == null || tab.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide");
            }
            int total = 0;
            int index = 0;

            do
            {
                total += tab[index];
                index++;
            } while (index < tab.Length);

            return total;
        }

        /// <summary>
        /// Affiche une forme sur la console
        /// </summary>
        public static void Exercice17()
        {
            Console.WriteLine("***\n***\n***");
        }

        /// <summary>
        /// Affiche une forme sur la console avec une largeur donnée
        /// </summary>
        /// <param name="largeur">Largeur de la forme voulu</param>
        public static void Exercice18(int largeur)
        {
            if (largeur < 0)
            {
                throw new ArgumentException("La largeur doit etre positive");
            }
            for (int i = 3; i > 0; i--)
            {
                for (int j = 0; j < largeur; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Affiche une forme sur la console avec une largeur donnée
        /// </summary>
        /// <param name="largeur">Largeur de la forme voulu</param>
        public static void Exercice19(int largeur)
        {
            if (largeur < 0)
            {
                largeur = Math.Abs(largeur);
            }
            for (int i = 3; i > 0; i--)
            {
                int cpt = 0;
                while (cpt < largeur)
                {
                    Console.Write("*");
                    cpt++;
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Affiche une forme sur la console avec des grandeurs de coté donnée
        /// </summary>
        /// <param name="largeur">Largeur de la forme voulu</param>
        /// <param name="hauteur">Hauteur de la forme voulu</param>
        public static void Exercice20(int largeur, int hauteur)
        {
            if (largeur < 1 || hauteur < 1)
            {
                Debug.WriteLine("Impossible d'afficher parce que dimension trop petite ( < 1 )", "Exercice 20");
                return;
            }
            for (int i = hauteur; i > 0; i--)
            {
                for (int j = largeur; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Affiche une forme sur la console avec des grandeurs de coté donnée
        /// </summary>
        /// <param name="largeur">Largeur de la forme voulu</param>
        /// <param name="hauteur">Hauteur de la forme voulu</param>
        /// <param name="charac">Caractère à afficher pour composer la forme</param>
        public static void Exercice21(int largeur, int hauteur, char charac)
        {
            if (largeur < 1 || hauteur < 0)
            {
                Debug.WriteLine("Impossible d'afficher parce que dimension trop petite ( < 1 )", "Exercice 21");
                return;
            }
            for (int i = hauteur; i > 0; i--)
            {
                for (int j = largeur; j > 0; j--)
                {
                    Console.Write($"{charac}");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Affiche une forme sur la console avec des grandeurs de coté donnée
        /// </summary>
        /// <param name="largeur">Largeur de la forme voulu</param>
        /// <param name="hauteur">Hauteur de la forme voulu</param>
        /// <param name="nbs">Nombre de fois que la forme sera afficher</param>
        /// <param name="charac">Caractère à afficher pour composer la forme</param>
        public static void Exercice22(int largeur, int hauteur, int nbs, char charac)
        {
            if (largeur < 1 || hauteur < 1 || nbs < 1)
            {
                Debug.WriteLine("Impossible d'afficher parce que dimension trop petite ( < 1 )", "Exercice 22");
                return;
            }
            for (int c = 0; c < nbs; c++)
            {
                for (int i = hauteur; i > 0; i--)
                {
                    for (int j = largeur; j > 0; j--)
                    {
                        Console.Write($"{charac}");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Affiche une forme sur la console
        /// </summary>
        /// <param name="longueur">La longueur de la plus longue ligne </param>
        public static void Exercice23(int longueur)
        {
            if (longueur < 0)
            {
                Debug.WriteLine("La longueur est inférieure a 0", "Exercice 23");
            }
            for (int i = longueur; i >= 0; i--)
            {
                for (int j = i; j < longueur; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Affiche une forme sur la console
        /// </summary>
        /// <param name="longueur">La longueur de la plus longue ligne </param>
        public static void Exercice24(int longueur)
        {
            if (longueur < 0)
            {
                Debug.WriteLine("La longueur est inférieure a 0", "Exercice 24");
            }
            int cpt1 = 0;
            while (cpt1 < longueur)
            {
                int cpt2 = cpt1;
                while (cpt2 < longueur)
                {
                    Console.Write("*");
                    cpt2++;
                }
                if (cpt1 <= longueur - 2)
                {
                    Console.Write("\n");
                }
                cpt1++;
            }
        }

        /// <summary>
        /// Affiche une forme sur la console
        /// </summary>
        /// <param name="longueur">La longueur de la plus longue ligne </param>
        public static void Exercice25(int longueur)
        {
            if (longueur < 0)
            {
                Debug.WriteLine("La longueur est inférieure a 0", "Exercice 25");
            }
            int cpt1 = 0;
            do
            {
                int cpt2 = cpt1;
                do
                {
                    Console.Write("*");
                    cpt2++;
                } while (cpt2 < longueur);
                Console.Write("\n");
                cpt1++;
            } while (cpt1 < longueur);
        }

        /// <summary>
        /// Affiche une forme sur la console
        /// </summary>
        /// <param name="longueur">La longueur de la plus longue ligne </param>
        public static void Exercice26(int longueur)
        {
            if (longueur < 0)
            {
                Debug.WriteLine("La longueur est inférieure a 0", "Exercice 26");
            }
            Exercice24(longueur);
            Console.CursorTop -= 1;
            Exercice23(longueur);
        }

        /// <summary>
        /// Créer un string qui represente une forme de longueur donnée.
        /// </summary>
        /// <param name="longueur">La longueur de la plus longue ligne </param>
        /// <returns>String qui contient la forme.</returns>
        public static string Exercice27(int longueur)
        {
            if (longueur < 0)
            {
                Debug.WriteLine("La longueur est inférieure a 0", "Exercice 27");
            }
            string str = "";
            for (int i = longueur; i > 0; i--)
            {
                for (int j = i; j < longueur + 1; j++)
                {
                    str += "*";
                    if (longueur != j)
                    {
                        str += " ";
                    }
                }
                if (i > 1)
                {
                    str += "\n";
                }
            }
            return str;
        }

        /// <summary>
        /// Calcule la moyenne d'un tableau de nombres.
        /// </summary>
        /// <param name="tab">Tableau de nombres à calculer la moyenne</param>
        /// <returns>La moyenne des nombres du tableau</returns>
        public static double Exercice28(int[] tab)
        {
            double total = 0;
            foreach (double num in tab)
            {
                total += num;
            }
            return total / tab.Length;
        }

        /// <summary>
        /// Calcule la moyenne des écarts de moyenne d'un tablaeau de nombres.
        /// </summary>
        /// <param name="tab">Tableau de nombres à calculer la moyenne</param>
        /// <returns>La moyenne des écarts</returns>
        public static double Exercice29(int[] tab)
        {
            if (tab == null || tab.Length == 0)
            {
                throw new ArgumentException("Le tableau ne peut pas etre vide");
            }
            double moyenne = Exercice28(tab);
            double[] ecarts = new double[tab.Length];
            double total = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                ecarts[i] = tab[i] - moyenne;
                if (ecarts[i] < 0)
                {
                    ecarts[i] *= -1;
                }
                total += ecarts[i];
            }
            return total / tab.Length;
        }

        /// <summary>
        /// Crée un tableau de personnes aléatoires.
        /// </summary>
        /// <param name="nbsPers">Nombre de personnes à créer.</param>
        /// <param name="ageMin">Âge minimum possible.</param>
        /// <param name="ageMax">Âge maximum possible.</param>
        /// <param name="prenom">Liste des prénoms possibles.</param>
        /// <param name="nom">Liste des noms possibles.</param>
        /// <returns>Tableau de personnes générées aléatoirement.</returns>
        public static Personne[] Exercice31(int nbsPers, int ageMin, int ageMax, string[] prenom, string[] nom)
        {
            if (nbsPers < 0)
            {
                throw new ArgumentException("Le nombre de personnes doit etre positive");
            }
            if (ageMin < 0)
            {
                throw new ArgumentException("L'âge minimum doit etre positive");
            }
            if (ageMax < 0)
            {
                throw new ArgumentException("L'âge maximum doit etre positive");
            }
            if (ageMin > ageMax)
            {
                throw new ArgumentException("L'âge minimum doit etre inferieur ou egale au maximum");
            }
            if (prenom == null || prenom.Length == 0)
            {
                throw new ArgumentException("Le tableau de prénoms ne peut pas etre vide");
            }
            if (nom == null || nom.Length == 0)
            {
                throw new ArgumentException("Le tableau de noms ne peut pas etre vide");
            }
            Personne[] lstPers = new Personne[nbsPers];
            Random rng = new();

            for (int i = 0; i < nbsPers; i++)
            {
                lstPers[i] = new Personne(
                    prenom![rng.Next(prenom.Length)],
                    nom![rng.Next(nom.Length)],
                    rng.Next(ageMin, ageMax + 1)
                );
            }

            return lstPers;
        }

        /// <summary>
        /// Calcule la moyenne d'age d'un tableau de personnes.
        /// </summary>
        /// <param name="tab">Tableau de personnes à calculer la moyenne des ages</param>
        /// <returns>La moyenne des ages</returns>
        public static double Exercice32(Personne[] tab)
        {
            if (tab == null || tab.Length == 0)
            {
                return 0;
            }

            int[] tabIntPersonnes = new int[tab.Length];

            for (int i = 0; i < tab.Length; i++)
            {
                tabIntPersonnes[i] = tab[i].Age;
            }

            return Exercice28(tabIntPersonnes);
        }

        /// <summary>
        /// Trouve la première personne ayant l'age le plus haut.
        /// </summary>
        /// <param name="tab">Tableau de personne</param>
        /// <returns>L'instance de la personne</returns>
        public static Personne Exercice33(Personne[] tab)
        {
            int plusHaut = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[plusHaut].Age < tab[i].Age)
                {
                    plusHaut = i;
                }
            }
            return tab[plusHaut];
        }

        /// <summary>
        /// Echange la position de deux nombres dans un tableau
        /// </summary>
        /// <param name="tabInt">Tableau de nombres</param>
        /// <param name="pos1">Position 1</param>
        /// <param name="pos2">Position 2</param>
        public static void Exercice34(int[] tabInt, int pos1, int pos2)
        {
            if (pos1 < 0)
            {
                throw new ArgumentException($"Position 1 est inferieur a 0 ( pos : {pos1})");
            }
            if (pos2 < 0)
            {
                throw new ArgumentException($"Position 2 est inferieur a 0 ( pos : {pos2})");
            }
            if (pos1 > tabInt.Length)
            {
                throw new ArgumentException($"Position 1 est superieur a la longueur du tableau ( pos : {pos1})");
            }
            if (pos2 > tabInt.Length)
            {
                throw new ArgumentException($"Position 2 est superieur a la longueur du tableau ( pos : {pos2})");
            }

            // Utilisation du tuple (IDE0180)
            // int temp = tabInt[pos1];
            // tabInt[pos1] = tabInt[pos2];
            // tabInt[pos2] = temp;
            (tabInt[pos1], tabInt[pos2]) = (tabInt[pos2], tabInt[pos1]);

        }

        /// <summary>
        /// Inverse l'ordre des valeurs d'un tableau
        /// </summary>
        /// <param name="tabInt">Tableau de nombres</param>
        public static void Exercice35(int[] tabInt)
        {
            int[] tempTab = new int[tabInt.Length];

            for (int i = 0; i < tabInt.Length; i++)
            {
                tempTab[i] = tabInt[i];
            }

            for (int i = 0; i < tabInt.Length; i++)
            {
                tabInt[tabInt.Length - 1 - i] = tempTab[i];
            }
        }

        /// <summary>
        /// Inverse les deux moitiés d'un tableau, en gardant le milieu en place si la longueur est impaire
        /// </summary>
        /// <param name="tabInt">Tableau d'entiers</param>
        public static void Exercice36(int[] tabInt)
        {
            int longueur = tabInt.Length;
            int milieu = longueur / 2;
            int milieuImpair = longueur % 2;

            int[] premParti = new int[milieu];
            int[] deuxParti = new int[milieu];

            for (int i = 0; i < milieu; i++)
            {
                premParti[i] = tabInt[i];
            }

            for (int i = 0; i < milieu; i++)
            {
                deuxParti[i] = tabInt[milieu + milieuImpair + i];
            }

            for (int i = 0; i < milieu; i++)
            {
                tabInt[i] = deuxParti[i];
            }

            if (milieuImpair == 1)
            {
                tabInt[milieu] = tabInt[milieu];
            }

            for (int i = 0; i < milieu; i++)
            {
                tabInt[milieu + milieuImpair + i] = premParti[i];
            }
        }

        /// <summary>
        /// Retourne l'index de la premiere occurence d'un caractere dans un tableau de caractere
        /// </summary>
        /// <param name="tabC">Tableau de caractere</param>
        /// <param name="c">Caractere a trouver</param>
        /// <returns>Index de la premiere occurence</returns>
        public static int Exercice37(char[] tabC, char c)
        {
            for (int i = 0; i < tabC.Length; i++)
            {
                if (tabC[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Retourne l'index de la premiere occurence d'un nombre dans un tableau
        /// </summary>
        /// <param name="tabInt">Tableau d'entier</param>
        /// <returns>L'index de la premiere occurence</returns>
        public static int Exercice38(int[] tabInt)
        {
            for (int i = 0; i < tabInt.Length; i++)
            {
                for (int j = i + 1; j < tabInt.Length; j++)
                {
                    if (tabInt[i] == tabInt[j])
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// Trouve tous les index de tous les doublons et les met dans un tableau
        /// </summary>
        /// <param name="tabInt">Tableau d'entier</param>
        /// <returns>Tableau contenant les premiers index de tous les doublons</returns>
        public static int[] Exercice39(int[] tabInt)
        {
            List<int> dejaVue = new List<int>();
            List<int> tabIndexDoublons = new List<int>();

            for (int i = 0; i < tabInt.Length; i++)
            {
                if (!dejaVue.Contains(tabInt[i]))
                {
                    dejaVue.Add(tabInt[i]);

                    // Vérifie s'il y a au moins un doublon
                    for (int j = i + 1; j < tabInt.Length; j++)
                    {
                        if (tabInt[i] == tabInt[j])
                        {
                            tabIndexDoublons.Add(i);
                            continue;
                        }
                    }
                }
            }
            return tabIndexDoublons.ToArray();
        }

        #endregion

        /// <summary>
        /// Retourne un tableau contenant la fusion des deux tableaux
        /// </summary>
        /// <param name="tabInt1">Tableau d'entier 1</param>
        /// <param name="tabInt2">Tableau d'entier 2</param>
        /// <returns>Tableau contenant la fusion des deux tableaux</returns>
        public static int[] Exercice40(int[] tabInt1, int[] tabInt2)
        {
            int[] tabFusion = new int[tabInt1.Length + tabInt2.Length];
            int i = 0;
            for (int j = 0; j < tabInt1.Length; j++)
            {
                tabFusion[i] = tabInt1[j];
                i++;
            }
            for (int j = 0; j < tabInt2.Length; j++)
            {
                tabFusion[i] = tabInt2[j];
                i++;
            }
            return tabFusion;
        }



    }
}